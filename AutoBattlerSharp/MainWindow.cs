using AutoBattlerSharp.GUI.CustomControls;
using AutoBattlerSharp.Logic;
using AutoBattlerSharp.Logic.Models;
using AutoBattlerSharp.Logic.Models.Creatures;
using AutoBattlerSharp.Logic.Models.Items;
using System.Runtime.InteropServices;

namespace AutoBattlerSharp
{
    public partial class MainWindow : Form
    {
        private Random _random = new Random();
        private Battlefield _field;
        private bool _fightStarted = false;

        public MainWindow()
        {
            _field = new Battlefield();
            InitializeComponent();
            RenderDynamicGUI();
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            _field.CheckIfEitherPartyDied();

            if (_field.EveryoneDied)
            {
                _field.EveryoneDied = false;
                _fightStarted = false;
                FightButton.Enabled = true;
                GameTimer.Stop();
                RenderDynamicGUI();
                FightLogRichTextBox.Text += "There is no one left to attack! Consider adding some new fighters.\n";
                return;
            }

            if (!_fightStarted)
                _fightStarted = true;

            FightLogRichTextBox.Text += _field.Fight().Information;
            FightLogRichTextBox.SelectionStart = FightLogRichTextBox.Text.Length;
            FightLogRichTextBox.ScrollToCaret();
            RenderDynamicGUI();
        }

        private void ReleaseResources(Control control, bool disposeControl = false)
        {
            foreach (Control sub in control.Controls)
            {
                if (sub.Controls.Count > 0)
                    ReleaseResources(sub);

                sub.Controls.Clear();
                sub.Dispose();
            }

            control.Controls.Clear();

            if (disposeControl)
                control.Dispose();
        }

        /// <summary>
        /// Cursed workaround to stop dynamic controls from blinking
        /// </summary>
        /// <param name="Handle"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern long LockWindowUpdate(long Handle);

        private void RenderDynamicGUI()
        {
            try
            {
                LockWindowUpdate(AlliesFlowLayoutPanel.Handle.ToInt64());

                ReleaseResources(AlliesFlowLayoutPanel);

                foreach (Creature ally in _field.Allies)
                    AlliesFlowLayoutPanel.Controls.Add(GetHumanControl(ally, _field.Allies, true));

                if (!_fightStarted)
                    AlliesFlowLayoutPanel.Controls.Add(GetAddControl(_field.Allies));
            }
            finally
            {
                LockWindowUpdate(0);
            }

            try
            {
                LockWindowUpdate(EnemiesFlowLayoutPanel.Handle.ToInt64());

                ReleaseResources(EnemiesFlowLayoutPanel);

                foreach (Creature enemy in _field.Enemies)
                    EnemiesFlowLayoutPanel.Controls.Add(GetHumanControl(enemy, _field.Enemies, false));

                if (!_fightStarted)
                    EnemiesFlowLayoutPanel.Controls.Add(GetAddControl(_field.Enemies));
            }
            finally
            {
                LockWindowUpdate(0);
            }
        }

        private Control GetHumanControl(Creature fighter, List<Human> fighters, bool ally)
        {
            Panel panel = new Panel()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Width = 256,
                Height = 128
            };

            Label name = new Label()
            {
                Height = 16,
                Text = $"{fighter.Name}",
                Dock = DockStyle.Top,
                ForeColor = ally ? Color.Green : Color.Red,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label type = new Label()
            {
                Height = 16,
                Text = (ally ? "(Ally)" : "(Enemy)"),
                Dock = DockStyle.Top,
                ForeColor = ally ? Color.Green : Color.Red,
                TextAlign = ContentAlignment.MiddleCenter
            };

            PictureBox health = new PictureBox()
            {
                Width = 168,
                Height = 32,
                Location = new Point(panel.Left + 8, panel.Bottom - 40),
                BackColor = Color.Red
            };

            using (var bmp = new Bitmap(health.Width, health.Height))
            using (var gfx = Graphics.FromImage(bmp))
            using (var brush = new SolidBrush(Color.Green))
            using (var brushText = new SolidBrush(Color.White))
            {
                gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                gfx.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                gfx.Clear(Color.Red);

                double healthProportion = (double)fighter.Attributes.Health / (double)fighter.Attributes.MaxHealth;
                int width = (int)Math.Round(health.Width * healthProportion) + 1;

                Rectangle healthBar = new Rectangle(-1, -1, width, 33);

                gfx.FillRectangle(brush, healthBar);

                gfx.DrawString($"{fighter.Attributes.Health}/{fighter.Attributes.MaxHealth}",
                               new Font("Segoe UI", 8), brushText, new Point(9, 9));

                health.Image?.Dispose();
                health.Image = (Bitmap)bmp.Clone();
            }

            Label state = new Label()
            {
                Text = fighter.Attributes.IsAlive ? "ALIVE" : "DEAD",
                Dock = DockStyle.Top,
                ForeColor = fighter.Attributes.IsAlive ? Color.Green : Color.Red,
                TextAlign = ContentAlignment.MiddleCenter
            };

            SafeButton inspect = new SafeButton((sender, e) =>
            {
                MessageBox.Show(fighter.ToString());
            })
            {
                Location = new Point(panel.Right - 40, panel.Bottom - 40),
                Width = 32,
                Height = 32,
                Text = "?"
            };

            SafeButton remove = new SafeButton((sender, e) =>
            {
                fighters.Remove((Human)fighter);

                ReleaseResources(panel, true);

                RenderDynamicGUI();
            })
            {
                Location = new Point(panel.Right - 72, panel.Bottom - 40),
                Width = 32,
                Height = 32,
                Text = "-"
            };

            panel.Controls.AddRange(new Control[]
            {
                health,
                state,
                type,
                name,
                inspect,
                remove
            });

            return panel;
        }

        private Control GetNumericUpDownWithLabel(string text)
        {
            Panel panel = new Panel()
            {
                Width = 64,
                Height = 40,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label label = new Label()
            {
                Width = 64,
                Height = 16,
                Dock = DockStyle.Top,
                Text = text
            };

            NumericUpDown number = new NumericUpDown()
            {
                Width = 64,
                Dock = DockStyle.Top
            };

            panel.Controls.Add(number);
            panel.Controls.Add(label);
            return panel;
        }

        private Control GetComboBoxWithLabel(string text, IEnumerable<Item> items)
        {
            Panel panel = new Panel()
            {
                Width = 134,
                Height = 40,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label label = new Label()
            {
                Width = 64,
                Height = 16,
                Dock = DockStyle.Top,
                Text = text
            };

            ComboBox combo = new ComboBox()
            {
                Width = 134,
                Dock = DockStyle.Top
            };
            combo.Items.AddRange(items.Select(item => item.Name)
                                      .ToArray());

            panel.Controls.Add(combo);
            panel.Controls.Add(label);

            return panel;
        }

        private Control GetAddControl(List<Human> fighters)
        {
            FlowLayoutPanel panelAdd = new FlowLayoutPanel()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Width = 256,
                Height = 256,
                AutoScroll = true
            };

            TextBox nameAdd = new TextBox()
            {
                Dock = DockStyle.Top,
                Text = "Name"
            };

            TextBox description = new TextBox()
            { 
                Dock = DockStyle.Top,
                Text = "Description"
            };

            CheckBox isAlive = new CheckBox()
            {
                Text = "Is alive?",
                Checked = true
            };

            CheckBox isAttackable = new CheckBox()
            {
                Text = "Is attackable?",
                Checked = true
            };

            var melee = GetNumericUpDownWithLabel("Melee");
            var range = GetNumericUpDownWithLabel("Range");
            var sturdiness = GetNumericUpDownWithLabel("Sturdiness");
            var resistance = GetNumericUpDownWithLabel("Resistance");
            var agility = GetNumericUpDownWithLabel("Agility");
            var intelligence = GetNumericUpDownWithLabel("Intelligence");
            var attacks = GetNumericUpDownWithLabel("Attacks");
            var health = GetNumericUpDownWithLabel("Health");
            var speed = GetNumericUpDownWithLabel("Speed");
            var strength = GetNumericUpDownWithLabel("Strength");
            var magic = GetNumericUpDownWithLabel("Magic");
            var weapon = GetComboBoxWithLabel("Weapon", _field.Weapons);

            SafeButton add = new SafeButton((sender, e) =>
            {
                Attributes attributes = new Attributes();
                attributes.IsAlive = isAlive.Checked;
                attributes.IsAttackable = isAttackable.Checked;
                attributes.Melee = (short)((NumericUpDown)melee.Controls[0]).Value;
                attributes.Range = (short)((NumericUpDown)range.Controls[0]).Value;
                attributes.Sturdiness = (short)((NumericUpDown)sturdiness.Controls[0]).Value;
                attributes.Resistance = (short)((NumericUpDown)resistance.Controls[0]).Value;
                attributes.Agility = (short)((NumericUpDown)agility.Controls[0]).Value;
                attributes.Intelligence = (short)((NumericUpDown)intelligence.Controls[0]).Value;
                attributes.Attacks = (short)((NumericUpDown)attacks.Controls[0]).Value;
                attributes.Health = (short)((NumericUpDown)health.Controls[0]).Value;
                attributes.MaxHealth = (short)((NumericUpDown)health.Controls[0]).Value;
                attributes.Speed = (short)((NumericUpDown)speed.Controls[0]).Value;
                attributes.Strength = (short)((NumericUpDown)strength.Controls[0]).Value;
                attributes.Magic = (short)((NumericUpDown)magic.Controls[0]).Value;

                Human human = new Human(nameAdd.Text, description.Text, attributes);

                human.Weapon = _field.Weapons.Where(item => item.Name == ((ComboBox)weapon.Controls[0]).Text)
                                             .FirstOrDefault();

                fighters.Add(human);

                ReleaseResources(melee);
                ReleaseResources(range);
                ReleaseResources(sturdiness);
                ReleaseResources(resistance);
                ReleaseResources(agility);
                ReleaseResources(intelligence);
                ReleaseResources(attacks);
                ReleaseResources(health);
                ReleaseResources(speed);
                ReleaseResources(strength);
                ReleaseResources(magic);


                if (attributes.IsAlive)
                    _field.EveryoneDied = false;

                RenderDynamicGUI();
            })
            {
                Width = 64,
                Height = 40,
                Text = "Add"
            };

            SafeButton randomize = new SafeButton((sender, e) =>
            {
                nameAdd.Text = _field.GetRandomName();

                ((NumericUpDown)melee.Controls[0]).Value = (short)_random.Next(10, 50);
                ((NumericUpDown)range.Controls[0]).Value = (short)_random.Next(10, 50);
                ((NumericUpDown)sturdiness.Controls[0]).Value = (short)_random.Next(10, 50);
                ((NumericUpDown)resistance.Controls[0]).Value = (short)_random.Next(10, 50);
                ((NumericUpDown)agility.Controls[0]).Value = (short)_random.Next(10, 50);
                ((NumericUpDown)intelligence.Controls[0]).Value = (short)_random.Next(10, 50);
                ((NumericUpDown)attacks.Controls[0]).Value = (short)_random.Next(1, 3);
                ((NumericUpDown)health.Controls[0]).Value = (short)_random.Next(5, 30);
                ((NumericUpDown)speed.Controls[0]).Value = (short)_random.Next(5, 30);
                ((NumericUpDown)strength.Controls[0]).Value = (short)_random.Next(5, 30);
                ((NumericUpDown)magic.Controls[0]).Value = (short)_random.Next(5, 30);
            })
            {
                Width = 64,
                Height = 40,
                Text = "Random"
            };

            panelAdd.Controls.AddRange(new Control[]
            {
                nameAdd,
                description,
                isAlive,
                isAttackable,
                melee,
                range,
                sturdiness,
                resistance,
                agility,
                intelligence,
                attacks,
                health,
                speed,
                strength,
                magic,
                weapon,
                add,
                randomize,
            });

            return panelAdd;
        }

        private void AutoplayButton_Click(object sender, EventArgs e)
        {
            if (GameTimer.Enabled)
            {
                GameTimer.Enabled = false;
                FightButton.Enabled = true;
                return;
            }

            FightButton.Enabled = false;
            GameTimer.Enabled = true;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            FightButton_Click(sender, e);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = FightersSaveFileDialog.ShowDialog();

            if (result != DialogResult.OK)
                return;

            using (Stream stream = FightersSaveFileDialog.OpenFile())
            {
                _field.SaveToFile(stream);
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = FightersOpenFileDialog.ShowDialog();

            if (result != DialogResult.OK)
                return;

            using(Stream stream = FightersOpenFileDialog.OpenFile())
            {
                _field.LoadFromFile(stream);
            }

            RenderDynamicGUI();
        }

        private void MainTimerIntervalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            GameTimer.Interval = (int)MainTimerIntervalNumericUpDown.Value;
        }

        private void SwordAddButton_Click(object sender, EventArgs e)
        {
            if (_field.Weapons
                     .Select(weapon => weapon.Name)
                     .Contains(SwordNameTextBox.Text))
            {
                MessageBox.Show("A weapon with this name already exists!");
                return;
            }

            Sword sword = new Sword(SwordNameTextBox.Text,
                                    SwordDescriptionTextBox.Text,
                                    (short)SwordValueNumericUpDown.Value,
                                    (short)SwordWeightNumericUpDown.Value,
                                    (short)SwordAttackPointsNumericUpDown.Value,
                                    (float)SwordAccuracyNumericUpDown.Value);

            _field.Weapons.Add(sword);

            RenderDynamicGUI();
        }
    }
}
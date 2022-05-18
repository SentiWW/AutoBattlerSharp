using AutoBattlerSharp.GUI;
using AutoBattlerSharp.Logic;
using AutoBattlerSharp.Logic.Models;
using AutoBattlerSharp.Logic.Models.Creatures;

namespace AutoBattlerSharp
{
    public partial class MainWindow : Form
    {
        private Random random = new Random();
        private Battlefield field;

        public MainWindow()
        {
            field = new Battlefield();
            InitializeComponent();
            RenderDynamicGUI();
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            FightLogRichTextBox.Text += field.Fight().Information;
            FightLogRichTextBox.SelectionStart = FightLogRichTextBox.Text.Length;
            FightLogRichTextBox.ScrollToCaret();
            RenderDynamicGUI();
        }

        private void ReleaseResources(Control control, bool deleteControl = false)
        {
            foreach (Control sub in control.Controls)
            {
                sub.Dispose();
            }
            control.Controls.Clear();

            if (deleteControl)
                control.Dispose();
        }

        private void RenderDynamicGUI()
        {
            //foreach (Control control in AlliesFlowLayoutPanel.Controls)
            //    control.Dispose();
            //AlliesFlowLayoutPanel.Controls.Clear();

            //foreach (Control control in EnemiesFlowLayoutPanel.Controls)
            //    control.Dispose();
            //EnemiesFlowLayoutPanel.Controls.Clear();

            ReleaseResources(AlliesFlowLayoutPanel);
            ReleaseResources(EnemiesFlowLayoutPanel);
           
            foreach (Creature ally in field.Allies)
                AlliesFlowLayoutPanel.Controls.Add(GetHumanControl(ally, field.Allies, true));

            foreach (Creature enemy in field.Enemies)
                EnemiesFlowLayoutPanel.Controls.Add(GetHumanControl(enemy, field.Enemies, false));

            RenderAddEntities();
        }

        private void RenderAddEntities()
        {
            AlliesFlowLayoutPanel.Controls.Add(GetAddControl(field.Allies));
            EnemiesFlowLayoutPanel.Controls.Add(GetAddControl(field.Enemies));
        }

        private Control GetHumanControl(Creature fighter, List<Human> fighters, bool ally)
        {
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Width = 256;
            panel.Height = 128;

            Label name = new Label();
            name.Height = 16;
            name.Text = $"{fighter.Name}";
            name.Dock = DockStyle.Top;
            name.ForeColor = ally ? Color.Green : Color.Red;
            name.TextAlign = ContentAlignment.MiddleCenter;

            Label type = new Label();
            type.Height = 16;
            type.Text = (ally ? "(Ally)" : "(Enemy)");
            type.Dock = DockStyle.Top;
            type.ForeColor = ally ? Color.Green : Color.Red;
            type.TextAlign = ContentAlignment.MiddleCenter;

            PictureBox health = new PictureBox();
            health.Width = 168;
            health.Height = 32;
            health.Location = new Point(panel.Left + 8, panel.Bottom - 40);
            health.BackColor = Color.Red;
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

            Label state = new Label();
            state.Text = fighter.Attributes.IsAlive ? "ALIVE" : "DEAD";
            state.Dock = DockStyle.Top;
            state.ForeColor = fighter.Attributes.IsAlive ? Color.Green : Color.Red;
            state.TextAlign = ContentAlignment.MiddleCenter;

            Button inspect = new Button();
            inspect.Location = new Point(panel.Right - 40, panel.Bottom - 40);
            inspect.Width = 32;
            inspect.Height = 32;
            inspect.Text = "?";
            inspect.Click += (sender, e) =>
            {
                MessageBox.Show(fighter.ToString());
            };

            Button remove = new Button();
            remove.Location = new Point(panel.Right - 72, panel.Bottom - 40);
            remove.Width = 32;
            remove.Height = 32;
            remove.Text = "-";
            remove.Click += (sender, e) =>
            {
                fighters.Remove((Human)fighter);

                ReleaseResources(panel, true);

                RenderDynamicGUI();
            };

            panel.Controls.Add(health);
            panel.Controls.Add(state);
            panel.Controls.Add(type);
            panel.Controls.Add(name);
            panel.Controls.Add(inspect);
            panel.Controls.Add(remove);

            return panel;
        }

        private Control GetNumericUpDownWithLabel(string text)
        {
            Panel panel = new Panel();
            panel.Width = 64;
            panel.Height = 40;
            panel.BorderStyle = BorderStyle.FixedSingle;

            Label label = new Label();
            label.Width = 64;
            label.Height = 16;
            label.Dock = DockStyle.Top;
            label.Text = text;

            NumericUpDown number = new NumericUpDown();
            number.Width = 64;
            number.Dock = DockStyle.Top;

            panel.Controls.Add(number);
            panel.Controls.Add(label);
            return panel;
        }

        private Control GetAddControl(List<Human> fighters)
        {
            FlowLayoutPanel panelAdd = new FlowLayoutPanel();
            panelAdd.BorderStyle = BorderStyle.FixedSingle;
            panelAdd.Width = 256;
            panelAdd.Height = 128;
            panelAdd.AutoScroll = true;

            TextBox nameAdd = new TextBox();
            nameAdd.Dock = DockStyle.Top;
            nameAdd.Text = "Name";

            TextBox description = new TextBox();
            description.Dock = DockStyle.Top;
            description.Text = "Description";

            CheckBox isAlive = new CheckBox();
            isAlive.Text = "Is alive?";
            isAlive.Checked = true;

            CheckBox isAttackable = new CheckBox();
            isAttackable.Text = "Is attackable?";
            isAttackable.Checked = true;


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

            Button add = new Button();
            add.Width = 64;
            add.Height = 40;
            add.Text = "Add";
            add.Click += (sender, e) =>
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

                fighters.Add(new Human(nameAdd.Text,
                                       description.Text,
                                       attributes));

                RenderDynamicGUI();
            };

            Button randomize = new Button();
            randomize.Width = 64;
            randomize.Height = 40;
            randomize.Text = "Random";
            randomize.Click += (sender, e) =>
            {
                nameAdd.Text = field.GetRandomName();

                ((NumericUpDown)melee.Controls[0]).Value = (short)random.Next(100);
                ((NumericUpDown)range.Controls[0]).Value = (short)random.Next(100);
                ((NumericUpDown)sturdiness.Controls[0]).Value = (short)random.Next(100);
                ((NumericUpDown)resistance.Controls[0]).Value = (short)random.Next(100);
                ((NumericUpDown)agility.Controls[0]).Value = (short)random.Next(100);
                ((NumericUpDown)intelligence.Controls[0]).Value = (short)random.Next(100);
                ((NumericUpDown)attacks.Controls[0]).Value = (short)random.Next(100);
                ((NumericUpDown)health.Controls[0]).Value = (short)random.Next(100);
                ((NumericUpDown)speed.Controls[0]).Value = (short)random.Next(100);
                ((NumericUpDown)strength.Controls[0]).Value = (short)random.Next(100);
                ((NumericUpDown)magic.Controls[0]).Value = (short)random.Next(100);
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
                add,
                randomize
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
                field.SaveToFile(stream);
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = FightersOpenFileDialog.ShowDialog();

            if (result != DialogResult.OK)
                return;

            using(Stream stream = FightersOpenFileDialog.OpenFile())
            {
                field.LoadFromFile(stream);
            }

            RenderDynamicGUI();
        }
    }
}
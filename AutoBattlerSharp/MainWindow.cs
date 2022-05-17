using AutoBattlerSharp.GUI;
using AutoBattlerSharp.Logic;
using AutoBattlerSharp.Logic.Models;

namespace AutoBattlerSharp
{
    public partial class MainWindow : Form
    {
        private Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            RenderDynamicGUI();
        }

        private void AddNewEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewEntity addNewEntityWindow = new AddNewEntity();
            addNewEntityWindow.FormClosed += HandleFormClosed;

            addNewEntityWindow.Show();
        }

        private void HandleFormClosed(object? sender, FormClosedEventArgs e)
        {
            if (sender is null)
                return;

            AddNewEntity closedForm = (AddNewEntity)sender;

            if (closedForm.Human is not null)
                MessageBox.Show(closedForm.Human.ToString());
        }

        Battlefield battlefield = new Battlefield();
        private void FightButton_Click(object sender, EventArgs e)
        {
            FightLogRichTextBox.Text += battlefield.Fight().Information;
            FightLogRichTextBox.SelectionStart = FightLogRichTextBox.Text.Length;
            FightLogRichTextBox.ScrollToCaret();
            RenderDynamicGUI();
        }

        private void RenderDynamicGUI()
        {
            AlliesFlowLayoutPanel.Controls.Clear();
            EnemiesFlowLayoutPanel.Controls.Clear();

            foreach (Creature ally in battlefield.Allies)
                AlliesFlowLayoutPanel.Controls.Add(GetHumanControl(ally, battlefield.Allies, true));

            foreach (Creature enemy in battlefield.Enemies)
                EnemiesFlowLayoutPanel.Controls.Add(GetHumanControl(enemy, battlefield.Enemies, false));

            RenderAddEntities();
        }

        private void RenderAddEntities()
        {
            AlliesFlowLayoutPanel.Controls.Add(GetAddControl(battlefield.Allies));
            EnemiesFlowLayoutPanel.Controls.Add(GetAddControl(battlefield.Enemies));
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
            {
                gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gfx.Clear(Color.Red);

                double healthProportion = (double)fighter.Attributes.Health / (double)fighter.Attributes.MaxHealth;
                int width = (int)Math.Round(health.Width * healthProportion) + 1;

                Rectangle healthBar = new Rectangle(-1, -1, width, 33);

                gfx.FillRectangle(brush, healthBar);

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

            NumericUpDown melee = new NumericUpDown();
            melee.Width = 64;

            NumericUpDown range = new NumericUpDown();
            range.Width = 64;

            NumericUpDown sturdiness = new NumericUpDown();
            sturdiness.Width = 64;

            NumericUpDown resistance = new NumericUpDown();
            resistance.Width = 64;

            NumericUpDown agility = new NumericUpDown();
            agility.Width = 64;

            NumericUpDown intelligence = new NumericUpDown();
            intelligence.Width = 64;

            NumericUpDown attacks = new NumericUpDown();
            attacks.Width = 64;

            NumericUpDown health = new NumericUpDown();
            health.Width = 64;

            NumericUpDown speed = new NumericUpDown();
            speed.Width = 64;

            NumericUpDown strength = new NumericUpDown();
            strength.Width = 64;

            NumericUpDown magic = new NumericUpDown();
            magic.Width = 64;

            Button add = new Button();
            add.Text = "Add";
            add.Click += (sender, e) =>
            {
                Attributes attributes = new Attributes();
                attributes.IsAlive = isAlive.Checked;
                attributes.IsAttackable = isAttackable.Checked;
                attributes.Melee = (short)melee.Value;
                attributes.Range = (short)range.Value;
                attributes.Sturdiness = (short)sturdiness.Value;
                attributes.Resistance = (short)resistance.Value;
                attributes.Agility = (short)agility.Value;
                attributes.Intelligence = (short)intelligence.Value;
                attributes.Attacks = (short)attacks.Value;
                attributes.Health = (short)health.Value;
                attributes.MaxHealth = (short)health.Value;
                attributes.Speed = (short)speed.Value;
                attributes.Strength = (short)strength.Value;
                attributes.Magic = (short)magic.Value;

                fighters.Add(new Human(nameAdd.Text,
                                       description.Text,
                                       attributes));

                RenderDynamicGUI();
            };

            Button randomize = new Button();
            randomize.Text = "Randomize";
            randomize.Click += (sender, e) =>
            {
                melee.Value = (short)random.Next(100);
                range.Value = (short)random.Next(100);
                sturdiness.Value = (short)random.Next(100);
                resistance.Value = (short)random.Next(100);
                agility.Value = (short)random.Next(100);
                intelligence.Value = (short)random.Next(100);
                attacks.Value = (short)random.Next(100);
                health.Value = (short)random.Next(100);
                speed.Value = (short)random.Next(100);
                strength.Value = (short)random.Next(100);
                magic.Value = (short)random.Next(100);
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
                battlefield.SaveToFile(stream);
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = FightersOpenFileDialog.ShowDialog();

            if (result != DialogResult.OK)
                return;

            using(Stream stream = FightersOpenFileDialog.OpenFile())
            {
                battlefield.LoadFromFile(stream);
            }

            RenderDynamicGUI();
        }
    }
}
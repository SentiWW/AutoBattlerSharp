namespace AutoBattlerSharp
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.FileToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanelPadded = new System.Windows.Forms.Panel();
            this.HorizontalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FightersSplitContainer = new System.Windows.Forms.SplitContainer();
            this.AlliesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.EnemiesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BottomSplitContainerVertical = new System.Windows.Forms.SplitContainer();
            this.BottomLeftFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GameControlsPanel = new System.Windows.Forms.Panel();
            this.FightButton = new System.Windows.Forms.Button();
            this.AutoplayButton = new System.Windows.Forms.Button();
            this.MainTimerIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.WeaponsPanel = new System.Windows.Forms.Panel();
            this.WeaponsTabControl = new System.Windows.Forms.TabControl();
            this.SwordTabPage = new System.Windows.Forms.TabPage();
            this.SwordAddButton = new System.Windows.Forms.Button();
            this.SwordAccuracyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SwordAccuracyLabel = new System.Windows.Forms.Label();
            this.SwordAttackPointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SwordAttackPointsLabel = new System.Windows.Forms.Label();
            this.SwordWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SwordWeightLabel = new System.Windows.Forms.Label();
            this.SwordValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SwordValueLabel = new System.Windows.Forms.Label();
            this.SwordDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SwordDescriptionLabel = new System.Windows.Forms.Label();
            this.SwordNameTextBox = new System.Windows.Forms.TextBox();
            this.SwordNameLabel = new System.Windows.Forms.Label();
            this.MagicWandTabPage = new System.Windows.Forms.TabPage();
            this.MagicWandAddButton = new System.Windows.Forms.Button();
            this.MagicWandAttackPointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MagicWandAttackPointsLabel = new System.Windows.Forms.Label();
            this.MagicWandWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MagicWandWeightLabel = new System.Windows.Forms.Label();
            this.MagicWandValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MagicWandValueLabel = new System.Windows.Forms.Label();
            this.MagicWandDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.MagicWandDescriptionLabel = new System.Windows.Forms.Label();
            this.MagicWandNameTextBox = new System.Windows.Forms.TextBox();
            this.MagicWandNameLabel = new System.Windows.Forms.Label();
            this.FightLogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.FightersSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.FightersOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TopToolStrip.SuspendLayout();
            this.MainPanelPadded.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitContainer)).BeginInit();
            this.HorizontalSplitContainer.Panel1.SuspendLayout();
            this.HorizontalSplitContainer.Panel2.SuspendLayout();
            this.HorizontalSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FightersSplitContainer)).BeginInit();
            this.FightersSplitContainer.Panel1.SuspendLayout();
            this.FightersSplitContainer.Panel2.SuspendLayout();
            this.FightersSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomSplitContainerVertical)).BeginInit();
            this.BottomSplitContainerVertical.Panel1.SuspendLayout();
            this.BottomSplitContainerVertical.Panel2.SuspendLayout();
            this.BottomSplitContainerVertical.SuspendLayout();
            this.BottomLeftFlowLayoutPanel.SuspendLayout();
            this.GameControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTimerIntervalNumericUpDown)).BeginInit();
            this.WeaponsPanel.SuspendLayout();
            this.WeaponsTabControl.SuspendLayout();
            this.SwordTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwordAccuracyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordAttackPointsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordWeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordValueNumericUpDown)).BeginInit();
            this.MagicWandTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MagicWandAttackPointsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagicWandWeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagicWandValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripDropDownButton});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(800, 25);
            this.TopToolStrip.TabIndex = 0;
            this.TopToolStrip.Text = "TopToolStrip";
            // 
            // FileToolStripDropDownButton
            // 
            this.FileToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.FileToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("FileToolStripDropDownButton.Image")));
            this.FileToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileToolStripDropDownButton.Name = "FileToolStripDropDownButton";
            this.FileToolStripDropDownButton.Size = new System.Drawing.Size(38, 22);
            this.FileToolStripDropDownButton.Text = "File";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // MainPanelPadded
            // 
            this.MainPanelPadded.Controls.Add(this.HorizontalSplitContainer);
            this.MainPanelPadded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelPadded.Location = new System.Drawing.Point(0, 25);
            this.MainPanelPadded.Name = "MainPanelPadded";
            this.MainPanelPadded.Padding = new System.Windows.Forms.Padding(5);
            this.MainPanelPadded.Size = new System.Drawing.Size(800, 523);
            this.MainPanelPadded.TabIndex = 1;
            // 
            // HorizontalSplitContainer
            // 
            this.HorizontalSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HorizontalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HorizontalSplitContainer.Location = new System.Drawing.Point(5, 5);
            this.HorizontalSplitContainer.Name = "HorizontalSplitContainer";
            this.HorizontalSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HorizontalSplitContainer.Panel1
            // 
            this.HorizontalSplitContainer.Panel1.Controls.Add(this.FightersSplitContainer);
            // 
            // HorizontalSplitContainer.Panel2
            // 
            this.HorizontalSplitContainer.Panel2.AutoScroll = true;
            this.HorizontalSplitContainer.Panel2.Controls.Add(this.BottomSplitContainerVertical);
            this.HorizontalSplitContainer.Size = new System.Drawing.Size(790, 513);
            this.HorizontalSplitContainer.SplitterDistance = 255;
            this.HorizontalSplitContainer.TabIndex = 0;
            // 
            // FightersSplitContainer
            // 
            this.FightersSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FightersSplitContainer.IsSplitterFixed = true;
            this.FightersSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.FightersSplitContainer.Name = "FightersSplitContainer";
            // 
            // FightersSplitContainer.Panel1
            // 
            this.FightersSplitContainer.Panel1.Controls.Add(this.AlliesFlowLayoutPanel);
            // 
            // FightersSplitContainer.Panel2
            // 
            this.FightersSplitContainer.Panel2.Controls.Add(this.EnemiesFlowLayoutPanel);
            this.FightersSplitContainer.Size = new System.Drawing.Size(788, 253);
            this.FightersSplitContainer.SplitterDistance = 394;
            this.FightersSplitContainer.TabIndex = 0;
            // 
            // AlliesFlowLayoutPanel
            // 
            this.AlliesFlowLayoutPanel.AutoScroll = true;
            this.AlliesFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlliesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlliesFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AlliesFlowLayoutPanel.Name = "AlliesFlowLayoutPanel";
            this.AlliesFlowLayoutPanel.Size = new System.Drawing.Size(394, 253);
            this.AlliesFlowLayoutPanel.TabIndex = 0;
            // 
            // EnemiesFlowLayoutPanel
            // 
            this.EnemiesFlowLayoutPanel.AutoScroll = true;
            this.EnemiesFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnemiesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnemiesFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.EnemiesFlowLayoutPanel.Name = "EnemiesFlowLayoutPanel";
            this.EnemiesFlowLayoutPanel.Size = new System.Drawing.Size(390, 253);
            this.EnemiesFlowLayoutPanel.TabIndex = 0;
            // 
            // BottomSplitContainerVertical
            // 
            this.BottomSplitContainerVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomSplitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomSplitContainerVertical.Location = new System.Drawing.Point(0, 0);
            this.BottomSplitContainerVertical.Name = "BottomSplitContainerVertical";
            // 
            // BottomSplitContainerVertical.Panel1
            // 
            this.BottomSplitContainerVertical.Panel1.Controls.Add(this.BottomLeftFlowLayoutPanel);
            // 
            // BottomSplitContainerVertical.Panel2
            // 
            this.BottomSplitContainerVertical.Panel2.Controls.Add(this.FightLogRichTextBox);
            this.BottomSplitContainerVertical.Size = new System.Drawing.Size(790, 254);
            this.BottomSplitContainerVertical.SplitterDistance = 250;
            this.BottomSplitContainerVertical.TabIndex = 0;
            // 
            // BottomLeftFlowLayoutPanel
            // 
            this.BottomLeftFlowLayoutPanel.AutoScroll = true;
            this.BottomLeftFlowLayoutPanel.Controls.Add(this.GameControlsPanel);
            this.BottomLeftFlowLayoutPanel.Controls.Add(this.WeaponsPanel);
            this.BottomLeftFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomLeftFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomLeftFlowLayoutPanel.Name = "BottomLeftFlowLayoutPanel";
            this.BottomLeftFlowLayoutPanel.Size = new System.Drawing.Size(248, 252);
            this.BottomLeftFlowLayoutPanel.TabIndex = 5;
            // 
            // GameControlsPanel
            // 
            this.GameControlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameControlsPanel.Controls.Add(this.FightButton);
            this.GameControlsPanel.Controls.Add(this.AutoplayButton);
            this.GameControlsPanel.Controls.Add(this.MainTimerIntervalNumericUpDown);
            this.GameControlsPanel.Controls.Add(this.IntervalLabel);
            this.GameControlsPanel.Location = new System.Drawing.Point(3, 3);
            this.GameControlsPanel.Name = "GameControlsPanel";
            this.GameControlsPanel.Padding = new System.Windows.Forms.Padding(3);
            this.GameControlsPanel.Size = new System.Drawing.Size(142, 92);
            this.GameControlsPanel.TabIndex = 5;
            // 
            // FightButton
            // 
            this.FightButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FightButton.Location = new System.Drawing.Point(3, 64);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(134, 23);
            this.FightButton.TabIndex = 0;
            this.FightButton.Text = "Fight";
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // AutoplayButton
            // 
            this.AutoplayButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoplayButton.Location = new System.Drawing.Point(3, 41);
            this.AutoplayButton.Name = "AutoplayButton";
            this.AutoplayButton.Size = new System.Drawing.Size(134, 23);
            this.AutoplayButton.TabIndex = 2;
            this.AutoplayButton.Text = "Autoplay";
            this.AutoplayButton.UseVisualStyleBackColor = true;
            this.AutoplayButton.Click += new System.EventHandler(this.AutoplayButton_Click);
            // 
            // MainTimerIntervalNumericUpDown
            // 
            this.MainTimerIntervalNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTimerIntervalNumericUpDown.Location = new System.Drawing.Point(3, 18);
            this.MainTimerIntervalNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MainTimerIntervalNumericUpDown.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.MainTimerIntervalNumericUpDown.Name = "MainTimerIntervalNumericUpDown";
            this.MainTimerIntervalNumericUpDown.Size = new System.Drawing.Size(134, 23);
            this.MainTimerIntervalNumericUpDown.TabIndex = 3;
            this.MainTimerIntervalNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.MainTimerIntervalNumericUpDown.ValueChanged += new System.EventHandler(this.MainTimerIntervalNumericUpDown_ValueChanged);
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IntervalLabel.Location = new System.Drawing.Point(3, 3);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(79, 15);
            this.IntervalLabel.TabIndex = 4;
            this.IntervalLabel.Text = "Timer Interval";
            // 
            // WeaponsPanel
            // 
            this.WeaponsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeaponsPanel.Controls.Add(this.WeaponsTabControl);
            this.WeaponsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WeaponsPanel.Location = new System.Drawing.Point(3, 101);
            this.WeaponsPanel.Name = "WeaponsPanel";
            this.WeaponsPanel.Padding = new System.Windows.Forms.Padding(3);
            this.WeaponsPanel.Size = new System.Drawing.Size(142, 290);
            this.WeaponsPanel.TabIndex = 6;
            // 
            // WeaponsTabControl
            // 
            this.WeaponsTabControl.Controls.Add(this.SwordTabPage);
            this.WeaponsTabControl.Controls.Add(this.MagicWandTabPage);
            this.WeaponsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeaponsTabControl.Location = new System.Drawing.Point(3, 3);
            this.WeaponsTabControl.Name = "WeaponsTabControl";
            this.WeaponsTabControl.SelectedIndex = 0;
            this.WeaponsTabControl.Size = new System.Drawing.Size(134, 282);
            this.WeaponsTabControl.TabIndex = 0;
            // 
            // SwordTabPage
            // 
            this.SwordTabPage.Controls.Add(this.SwordAddButton);
            this.SwordTabPage.Controls.Add(this.SwordAccuracyNumericUpDown);
            this.SwordTabPage.Controls.Add(this.SwordAccuracyLabel);
            this.SwordTabPage.Controls.Add(this.SwordAttackPointsNumericUpDown);
            this.SwordTabPage.Controls.Add(this.SwordAttackPointsLabel);
            this.SwordTabPage.Controls.Add(this.SwordWeightNumericUpDown);
            this.SwordTabPage.Controls.Add(this.SwordWeightLabel);
            this.SwordTabPage.Controls.Add(this.SwordValueNumericUpDown);
            this.SwordTabPage.Controls.Add(this.SwordValueLabel);
            this.SwordTabPage.Controls.Add(this.SwordDescriptionTextBox);
            this.SwordTabPage.Controls.Add(this.SwordDescriptionLabel);
            this.SwordTabPage.Controls.Add(this.SwordNameTextBox);
            this.SwordTabPage.Controls.Add(this.SwordNameLabel);
            this.SwordTabPage.Location = new System.Drawing.Point(4, 24);
            this.SwordTabPage.Name = "SwordTabPage";
            this.SwordTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SwordTabPage.Size = new System.Drawing.Size(126, 254);
            this.SwordTabPage.TabIndex = 0;
            this.SwordTabPage.Text = "Sword";
            this.SwordTabPage.UseVisualStyleBackColor = true;
            // 
            // SwordAddButton
            // 
            this.SwordAddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordAddButton.Location = new System.Drawing.Point(3, 231);
            this.SwordAddButton.Name = "SwordAddButton";
            this.SwordAddButton.Size = new System.Drawing.Size(120, 23);
            this.SwordAddButton.TabIndex = 12;
            this.SwordAddButton.Text = "Add";
            this.SwordAddButton.UseVisualStyleBackColor = true;
            this.SwordAddButton.Click += new System.EventHandler(this.SwordAddButton_Click);
            // 
            // SwordAccuracyNumericUpDown
            // 
            this.SwordAccuracyNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordAccuracyNumericUpDown.Location = new System.Drawing.Point(3, 208);
            this.SwordAccuracyNumericUpDown.Name = "SwordAccuracyNumericUpDown";
            this.SwordAccuracyNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.SwordAccuracyNumericUpDown.TabIndex = 11;
            // 
            // SwordAccuracyLabel
            // 
            this.SwordAccuracyLabel.AutoSize = true;
            this.SwordAccuracyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordAccuracyLabel.Location = new System.Drawing.Point(3, 193);
            this.SwordAccuracyLabel.Name = "SwordAccuracyLabel";
            this.SwordAccuracyLabel.Size = new System.Drawing.Size(56, 15);
            this.SwordAccuracyLabel.TabIndex = 10;
            this.SwordAccuracyLabel.Text = "Accuracy";
            // 
            // SwordAttackPointsNumericUpDown
            // 
            this.SwordAttackPointsNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordAttackPointsNumericUpDown.Location = new System.Drawing.Point(3, 170);
            this.SwordAttackPointsNumericUpDown.Name = "SwordAttackPointsNumericUpDown";
            this.SwordAttackPointsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.SwordAttackPointsNumericUpDown.TabIndex = 9;
            // 
            // SwordAttackPointsLabel
            // 
            this.SwordAttackPointsLabel.AutoSize = true;
            this.SwordAttackPointsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordAttackPointsLabel.Location = new System.Drawing.Point(3, 155);
            this.SwordAttackPointsLabel.Name = "SwordAttackPointsLabel";
            this.SwordAttackPointsLabel.Size = new System.Drawing.Size(77, 15);
            this.SwordAttackPointsLabel.TabIndex = 8;
            this.SwordAttackPointsLabel.Text = "Attack Points";
            // 
            // SwordWeightNumericUpDown
            // 
            this.SwordWeightNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordWeightNumericUpDown.Location = new System.Drawing.Point(3, 132);
            this.SwordWeightNumericUpDown.Name = "SwordWeightNumericUpDown";
            this.SwordWeightNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.SwordWeightNumericUpDown.TabIndex = 7;
            // 
            // SwordWeightLabel
            // 
            this.SwordWeightLabel.AutoSize = true;
            this.SwordWeightLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordWeightLabel.Location = new System.Drawing.Point(3, 117);
            this.SwordWeightLabel.Name = "SwordWeightLabel";
            this.SwordWeightLabel.Size = new System.Drawing.Size(45, 15);
            this.SwordWeightLabel.TabIndex = 6;
            this.SwordWeightLabel.Text = "Weight";
            // 
            // SwordValueNumericUpDown
            // 
            this.SwordValueNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordValueNumericUpDown.Location = new System.Drawing.Point(3, 94);
            this.SwordValueNumericUpDown.Name = "SwordValueNumericUpDown";
            this.SwordValueNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.SwordValueNumericUpDown.TabIndex = 5;
            // 
            // SwordValueLabel
            // 
            this.SwordValueLabel.AutoSize = true;
            this.SwordValueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordValueLabel.Location = new System.Drawing.Point(3, 79);
            this.SwordValueLabel.Name = "SwordValueLabel";
            this.SwordValueLabel.Size = new System.Drawing.Size(35, 15);
            this.SwordValueLabel.TabIndex = 4;
            this.SwordValueLabel.Text = "Value";
            // 
            // SwordDescriptionTextBox
            // 
            this.SwordDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordDescriptionTextBox.Location = new System.Drawing.Point(3, 56);
            this.SwordDescriptionTextBox.Name = "SwordDescriptionTextBox";
            this.SwordDescriptionTextBox.Size = new System.Drawing.Size(120, 23);
            this.SwordDescriptionTextBox.TabIndex = 3;
            // 
            // SwordDescriptionLabel
            // 
            this.SwordDescriptionLabel.AutoSize = true;
            this.SwordDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordDescriptionLabel.Location = new System.Drawing.Point(3, 41);
            this.SwordDescriptionLabel.Name = "SwordDescriptionLabel";
            this.SwordDescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.SwordDescriptionLabel.TabIndex = 2;
            this.SwordDescriptionLabel.Text = "Description";
            // 
            // SwordNameTextBox
            // 
            this.SwordNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordNameTextBox.Location = new System.Drawing.Point(3, 18);
            this.SwordNameTextBox.Name = "SwordNameTextBox";
            this.SwordNameTextBox.Size = new System.Drawing.Size(120, 23);
            this.SwordNameTextBox.TabIndex = 1;
            // 
            // SwordNameLabel
            // 
            this.SwordNameLabel.AutoSize = true;
            this.SwordNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwordNameLabel.Location = new System.Drawing.Point(3, 3);
            this.SwordNameLabel.Name = "SwordNameLabel";
            this.SwordNameLabel.Size = new System.Drawing.Size(39, 15);
            this.SwordNameLabel.TabIndex = 0;
            this.SwordNameLabel.Text = "Name";
            // 
            // MagicWandTabPage
            // 
            this.MagicWandTabPage.Controls.Add(this.MagicWandAddButton);
            this.MagicWandTabPage.Controls.Add(this.MagicWandAttackPointsNumericUpDown);
            this.MagicWandTabPage.Controls.Add(this.MagicWandAttackPointsLabel);
            this.MagicWandTabPage.Controls.Add(this.MagicWandWeightNumericUpDown);
            this.MagicWandTabPage.Controls.Add(this.MagicWandWeightLabel);
            this.MagicWandTabPage.Controls.Add(this.MagicWandValueNumericUpDown);
            this.MagicWandTabPage.Controls.Add(this.MagicWandValueLabel);
            this.MagicWandTabPage.Controls.Add(this.MagicWandDescriptionTextBox);
            this.MagicWandTabPage.Controls.Add(this.MagicWandDescriptionLabel);
            this.MagicWandTabPage.Controls.Add(this.MagicWandNameTextBox);
            this.MagicWandTabPage.Controls.Add(this.MagicWandNameLabel);
            this.MagicWandTabPage.Location = new System.Drawing.Point(4, 24);
            this.MagicWandTabPage.Name = "MagicWandTabPage";
            this.MagicWandTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MagicWandTabPage.Size = new System.Drawing.Size(126, 254);
            this.MagicWandTabPage.TabIndex = 1;
            this.MagicWandTabPage.Text = "Magic Wand";
            this.MagicWandTabPage.UseVisualStyleBackColor = true;
            // 
            // MagicWandAddButton
            // 
            this.MagicWandAddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagicWandAddButton.Location = new System.Drawing.Point(3, 193);
            this.MagicWandAddButton.Name = "MagicWandAddButton";
            this.MagicWandAddButton.Size = new System.Drawing.Size(120, 23);
            this.MagicWandAddButton.TabIndex = 25;
            this.MagicWandAddButton.Text = "Add";
            this.MagicWandAddButton.UseVisualStyleBackColor = true;
            this.MagicWandAddButton.Click += new System.EventHandler(this.MagicWandAddButton_Click);
            // 
            // MagicWandAttackPointsNumericUpDown
            // 
            this.MagicWandAttackPointsNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagicWandAttackPointsNumericUpDown.Location = new System.Drawing.Point(3, 170);
            this.MagicWandAttackPointsNumericUpDown.Name = "MagicWandAttackPointsNumericUpDown";
            this.MagicWandAttackPointsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.MagicWandAttackPointsNumericUpDown.TabIndex = 22;
            // 
            // MagicWandAttackPointsLabel
            // 
            this.MagicWandAttackPointsLabel.AutoSize = true;
            this.MagicWandAttackPointsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagicWandAttackPointsLabel.Location = new System.Drawing.Point(3, 155);
            this.MagicWandAttackPointsLabel.Name = "MagicWandAttackPointsLabel";
            this.MagicWandAttackPointsLabel.Size = new System.Drawing.Size(77, 15);
            this.MagicWandAttackPointsLabel.TabIndex = 21;
            this.MagicWandAttackPointsLabel.Text = "Attack Points";
            // 
            // MagicWandWeightNumericUpDown
            // 
            this.MagicWandWeightNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagicWandWeightNumericUpDown.Location = new System.Drawing.Point(3, 132);
            this.MagicWandWeightNumericUpDown.Name = "MagicWandWeightNumericUpDown";
            this.MagicWandWeightNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.MagicWandWeightNumericUpDown.TabIndex = 20;
            // 
            // MagicWandWeightLabel
            // 
            this.MagicWandWeightLabel.AutoSize = true;
            this.MagicWandWeightLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagicWandWeightLabel.Location = new System.Drawing.Point(3, 117);
            this.MagicWandWeightLabel.Name = "MagicWandWeightLabel";
            this.MagicWandWeightLabel.Size = new System.Drawing.Size(45, 15);
            this.MagicWandWeightLabel.TabIndex = 19;
            this.MagicWandWeightLabel.Text = "Weight";
            // 
            // MagicWandValueNumericUpDown
            // 
            this.MagicWandValueNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagicWandValueNumericUpDown.Location = new System.Drawing.Point(3, 94);
            this.MagicWandValueNumericUpDown.Name = "MagicWandValueNumericUpDown";
            this.MagicWandValueNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.MagicWandValueNumericUpDown.TabIndex = 18;
            // 
            // MagicWandValueLabel
            // 
            this.MagicWandValueLabel.AutoSize = true;
            this.MagicWandValueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagicWandValueLabel.Location = new System.Drawing.Point(3, 79);
            this.MagicWandValueLabel.Name = "MagicWandValueLabel";
            this.MagicWandValueLabel.Size = new System.Drawing.Size(35, 15);
            this.MagicWandValueLabel.TabIndex = 17;
            this.MagicWandValueLabel.Text = "Value";
            // 
            // MagicWandDescriptionTextBox
            // 
            this.MagicWandDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagicWandDescriptionTextBox.Location = new System.Drawing.Point(3, 56);
            this.MagicWandDescriptionTextBox.Name = "MagicWandDescriptionTextBox";
            this.MagicWandDescriptionTextBox.Size = new System.Drawing.Size(120, 23);
            this.MagicWandDescriptionTextBox.TabIndex = 16;
            // 
            // MagicWandDescriptionLabel
            // 
            this.MagicWandDescriptionLabel.AutoSize = true;
            this.MagicWandDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagicWandDescriptionLabel.Location = new System.Drawing.Point(3, 41);
            this.MagicWandDescriptionLabel.Name = "MagicWandDescriptionLabel";
            this.MagicWandDescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.MagicWandDescriptionLabel.TabIndex = 15;
            this.MagicWandDescriptionLabel.Text = "Description";
            // 
            // MagicWandNameTextBox
            // 
            this.MagicWandNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagicWandNameTextBox.Location = new System.Drawing.Point(3, 18);
            this.MagicWandNameTextBox.Name = "MagicWandNameTextBox";
            this.MagicWandNameTextBox.Size = new System.Drawing.Size(120, 23);
            this.MagicWandNameTextBox.TabIndex = 14;
            // 
            // MagicWandNameLabel
            // 
            this.MagicWandNameLabel.AutoSize = true;
            this.MagicWandNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagicWandNameLabel.Location = new System.Drawing.Point(3, 3);
            this.MagicWandNameLabel.Name = "MagicWandNameLabel";
            this.MagicWandNameLabel.Size = new System.Drawing.Size(39, 15);
            this.MagicWandNameLabel.TabIndex = 13;
            this.MagicWandNameLabel.Text = "Name";
            // 
            // FightLogRichTextBox
            // 
            this.FightLogRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FightLogRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FightLogRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.FightLogRichTextBox.Name = "FightLogRichTextBox";
            this.FightLogRichTextBox.ReadOnly = true;
            this.FightLogRichTextBox.Size = new System.Drawing.Size(534, 252);
            this.FightLogRichTextBox.TabIndex = 1;
            this.FightLogRichTextBox.Text = "";
            this.FightLogRichTextBox.WordWrap = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 500;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // FightersSaveFileDialog
            // 
            this.FightersSaveFileDialog.DefaultExt = "json";
            this.FightersSaveFileDialog.FileName = "fighters";
            // 
            // FightersOpenFileDialog
            // 
            this.FightersOpenFileDialog.FileName = "fighters.json";
            this.FightersOpenFileDialog.Filter = "JSON files|*.json|All filed|*.*\"";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.MainPanelPadded);
            this.Controls.Add(this.TopToolStrip);
            this.Name = "MainWindow";
            this.Text = "AutoBattlerSharp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.MainPanelPadded.ResumeLayout(false);
            this.HorizontalSplitContainer.Panel1.ResumeLayout(false);
            this.HorizontalSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitContainer)).EndInit();
            this.HorizontalSplitContainer.ResumeLayout(false);
            this.FightersSplitContainer.Panel1.ResumeLayout(false);
            this.FightersSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FightersSplitContainer)).EndInit();
            this.FightersSplitContainer.ResumeLayout(false);
            this.BottomSplitContainerVertical.Panel1.ResumeLayout(false);
            this.BottomSplitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BottomSplitContainerVertical)).EndInit();
            this.BottomSplitContainerVertical.ResumeLayout(false);
            this.BottomLeftFlowLayoutPanel.ResumeLayout(false);
            this.GameControlsPanel.ResumeLayout(false);
            this.GameControlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTimerIntervalNumericUpDown)).EndInit();
            this.WeaponsPanel.ResumeLayout(false);
            this.WeaponsTabControl.ResumeLayout(false);
            this.SwordTabPage.ResumeLayout(false);
            this.SwordTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwordAccuracyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordAttackPointsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordWeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordValueNumericUpDown)).EndInit();
            this.MagicWandTabPage.ResumeLayout(false);
            this.MagicWandTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MagicWandAttackPointsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagicWandWeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagicWandValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip TopToolStrip;
        private Panel MainPanelPadded;
        private SplitContainer HorizontalSplitContainer;
        private Button FightButton;
        private RichTextBox FightLogRichTextBox;
        private SplitContainer BottomSplitContainerVertical;
        private SplitContainer FightersSplitContainer;
        private FlowLayoutPanel AlliesFlowLayoutPanel;
        private FlowLayoutPanel EnemiesFlowLayoutPanel;
        private Button AutoplayButton;
        private System.Windows.Forms.Timer GameTimer;
        private ToolStripDropDownButton FileToolStripDropDownButton;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private SaveFileDialog FightersSaveFileDialog;
        private OpenFileDialog FightersOpenFileDialog;
        private NumericUpDown MainTimerIntervalNumericUpDown;
        private Label IntervalLabel;
        private FlowLayoutPanel BottomLeftFlowLayoutPanel;
        private Panel GameControlsPanel;
        private Panel WeaponsPanel;
        private TabControl WeaponsTabControl;
        private TabPage SwordTabPage;
        private TabPage MagicWandTabPage;
        private TextBox SwordNameTextBox;
        private Label SwordNameLabel;
        private Label SwordDescriptionLabel;
        private TextBox SwordDescriptionTextBox;
        private NumericUpDown SwordWeightNumericUpDown;
        private Label SwordWeightLabel;
        private NumericUpDown SwordValueNumericUpDown;
        private Label SwordValueLabel;
        private NumericUpDown SwordAccuracyNumericUpDown;
        private Label SwordAccuracyLabel;
        private NumericUpDown SwordAttackPointsNumericUpDown;
        private Label SwordAttackPointsLabel;
        private Button SwordAddButton;
        private Button MagicWandAddButton;
        private NumericUpDown MagicWandAttackPointsNumericUpDown;
        private Label MagicWandAttackPointsLabel;
        private NumericUpDown MagicWandWeightNumericUpDown;
        private Label MagicWandWeightLabel;
        private NumericUpDown MagicWandValueNumericUpDown;
        private Label MagicWandValueLabel;
        private TextBox MagicWandDescriptionTextBox;
        private Label MagicWandDescriptionLabel;
        private TextBox MagicWandNameTextBox;
        private Label MagicWandNameLabel;
    }
}
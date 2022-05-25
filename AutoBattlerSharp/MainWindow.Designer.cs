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
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.MainTimerIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AutoplayButton = new System.Windows.Forms.Button();
            this.FightButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.MainTimerIntervalNumericUpDown)).BeginInit();
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
            this.MainPanelPadded.Size = new System.Drawing.Size(800, 425);
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
            this.HorizontalSplitContainer.Size = new System.Drawing.Size(790, 415);
            this.HorizontalSplitContainer.SplitterDistance = 207;
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
            this.FightersSplitContainer.Size = new System.Drawing.Size(788, 205);
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
            this.AlliesFlowLayoutPanel.Size = new System.Drawing.Size(394, 205);
            this.AlliesFlowLayoutPanel.TabIndex = 0;
            // 
            // EnemiesFlowLayoutPanel
            // 
            this.EnemiesFlowLayoutPanel.AutoScroll = true;
            this.EnemiesFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnemiesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnemiesFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.EnemiesFlowLayoutPanel.Name = "EnemiesFlowLayoutPanel";
            this.EnemiesFlowLayoutPanel.Size = new System.Drawing.Size(390, 205);
            this.EnemiesFlowLayoutPanel.TabIndex = 0;
            // 
            // BottomSplitContainerVertical
            // 
            this.BottomSplitContainerVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomSplitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomSplitContainerVertical.IsSplitterFixed = true;
            this.BottomSplitContainerVertical.Location = new System.Drawing.Point(0, 0);
            this.BottomSplitContainerVertical.Name = "BottomSplitContainerVertical";
            // 
            // BottomSplitContainerVertical.Panel1
            // 
            this.BottomSplitContainerVertical.Panel1.Controls.Add(this.IntervalLabel);
            this.BottomSplitContainerVertical.Panel1.Controls.Add(this.MainTimerIntervalNumericUpDown);
            this.BottomSplitContainerVertical.Panel1.Controls.Add(this.AutoplayButton);
            this.BottomSplitContainerVertical.Panel1.Controls.Add(this.FightButton);
            // 
            // BottomSplitContainerVertical.Panel2
            // 
            this.BottomSplitContainerVertical.Panel2.Controls.Add(this.FightLogRichTextBox);
            this.BottomSplitContainerVertical.Size = new System.Drawing.Size(790, 204);
            this.BottomSplitContainerVertical.SplitterDistance = 103;
            this.BottomSplitContainerVertical.TabIndex = 0;
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IntervalLabel.Location = new System.Drawing.Point(0, 118);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(79, 15);
            this.IntervalLabel.TabIndex = 4;
            this.IntervalLabel.Text = "Timer Interval";
            // 
            // MainTimerIntervalNumericUpDown
            // 
            this.MainTimerIntervalNumericUpDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainTimerIntervalNumericUpDown.Location = new System.Drawing.Point(0, 133);
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
            this.MainTimerIntervalNumericUpDown.Size = new System.Drawing.Size(101, 23);
            this.MainTimerIntervalNumericUpDown.TabIndex = 3;
            this.MainTimerIntervalNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.MainTimerIntervalNumericUpDown.ValueChanged += new System.EventHandler(this.MainTimerIntervalNumericUpDown_ValueChanged);
            // 
            // AutoplayButton
            // 
            this.AutoplayButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AutoplayButton.Location = new System.Drawing.Point(0, 156);
            this.AutoplayButton.Name = "AutoplayButton";
            this.AutoplayButton.Size = new System.Drawing.Size(101, 23);
            this.AutoplayButton.TabIndex = 2;
            this.AutoplayButton.Text = "Autoplay";
            this.AutoplayButton.UseVisualStyleBackColor = true;
            this.AutoplayButton.Click += new System.EventHandler(this.AutoplayButton_Click);
            // 
            // FightButton
            // 
            this.FightButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FightButton.Location = new System.Drawing.Point(0, 179);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(101, 23);
            this.FightButton.TabIndex = 0;
            this.FightButton.Text = "Fight";
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // FightLogRichTextBox
            // 
            this.FightLogRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FightLogRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FightLogRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.FightLogRichTextBox.Name = "FightLogRichTextBox";
            this.FightLogRichTextBox.ReadOnly = true;
            this.FightLogRichTextBox.Size = new System.Drawing.Size(681, 202);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.BottomSplitContainerVertical.Panel1.PerformLayout();
            this.BottomSplitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BottomSplitContainerVertical)).EndInit();
            this.BottomSplitContainerVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainTimerIntervalNumericUpDown)).EndInit();
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
    }
}
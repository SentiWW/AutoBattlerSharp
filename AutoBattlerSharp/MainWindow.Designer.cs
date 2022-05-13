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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.DebugToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.MainPanelPadded = new System.Windows.Forms.Panel();
            this.HorizontalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.AddNewEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopToolStrip.SuspendLayout();
            this.MainPanelPadded.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitContainer)).BeginInit();
            this.HorizontalSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DebugToolStripDropDownButton});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(800, 25);
            this.TopToolStrip.TabIndex = 0;
            this.TopToolStrip.Text = "TopToolStrip";
            // 
            // DebugToolStripDropDownButton
            // 
            this.DebugToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DebugToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewEntityToolStripMenuItem});
            this.DebugToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("DebugToolStripDropDownButton.Image")));
            this.DebugToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DebugToolStripDropDownButton.Name = "DebugToolStripDropDownButton";
            this.DebugToolStripDropDownButton.Size = new System.Drawing.Size(55, 22);
            this.DebugToolStripDropDownButton.Text = "Debug";
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
            this.HorizontalSplitContainer.Size = new System.Drawing.Size(790, 415);
            this.HorizontalSplitContainer.SplitterDistance = 207;
            this.HorizontalSplitContainer.TabIndex = 0;
            // 
            // AddNewEntityToolStripMenuItem
            // 
            this.AddNewEntityToolStripMenuItem.Name = "AddNewEntityToolStripMenuItem";
            this.AddNewEntityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddNewEntityToolStripMenuItem.Text = "Add new entity";
            this.AddNewEntityToolStripMenuItem.Click += new System.EventHandler(this.AddNewEntityToolStripMenuItem_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitContainer)).EndInit();
            this.HorizontalSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip TopToolStrip;
        private Panel MainPanelPadded;
        private SplitContainer HorizontalSplitContainer;
        private ToolStripDropDownButton DebugToolStripDropDownButton;
        private ToolStripMenuItem AddNewEntityToolStripMenuItem;
    }
}
namespace AutoBattlerSharp.GUI
{
    partial class AddNewEntity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNewEntityTabControl = new System.Windows.Forms.TabControl();
            this.HumanTab = new System.Windows.Forms.TabPage();
            this.HumanFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HumanNameTextBox = new System.Windows.Forms.TextBox();
            this.HumanDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AttributesTab = new System.Windows.Forms.TabPage();
            this.AttributesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AttributesIsAliveCheckBox = new System.Windows.Forms.CheckBox();
            this.AttributesIsAttackableCheckBox = new System.Windows.Forms.CheckBox();
            this.AttributesMeleeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttributesRangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttributesSturdinessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttributesResistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttributesAgilityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttributesIntelligenceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttributesAttacksNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttributesHealthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttributesSpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttributesStrengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttributesMagicNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddNewEntityTabControl.SuspendLayout();
            this.HumanTab.SuspendLayout();
            this.HumanFlowLayoutPanel.SuspendLayout();
            this.AttributesTab.SuspendLayout();
            this.AttributesFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesMeleeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesRangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesSturdinessNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesResistanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesAgilityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesIntelligenceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesAttacksNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesHealthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesSpeedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesStrengthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesMagicNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewEntityTabControl
            // 
            this.AddNewEntityTabControl.Controls.Add(this.HumanTab);
            this.AddNewEntityTabControl.Controls.Add(this.AttributesTab);
            this.AddNewEntityTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNewEntityTabControl.Location = new System.Drawing.Point(0, 0);
            this.AddNewEntityTabControl.Name = "AddNewEntityTabControl";
            this.AddNewEntityTabControl.SelectedIndex = 0;
            this.AddNewEntityTabControl.Size = new System.Drawing.Size(800, 450);
            this.AddNewEntityTabControl.TabIndex = 0;
            // 
            // HumanTab
            // 
            this.HumanTab.Controls.Add(this.HumanFlowLayoutPanel);
            this.HumanTab.Location = new System.Drawing.Point(4, 24);
            this.HumanTab.Name = "HumanTab";
            this.HumanTab.Padding = new System.Windows.Forms.Padding(3);
            this.HumanTab.Size = new System.Drawing.Size(792, 422);
            this.HumanTab.TabIndex = 0;
            this.HumanTab.Text = "Human";
            this.HumanTab.UseVisualStyleBackColor = true;
            // 
            // HumanFlowLayoutPanel
            // 
            this.HumanFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HumanFlowLayoutPanel.Controls.Add(this.HumanNameTextBox);
            this.HumanFlowLayoutPanel.Controls.Add(this.HumanDescriptionTextBox);
            this.HumanFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HumanFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.HumanFlowLayoutPanel.Name = "HumanFlowLayoutPanel";
            this.HumanFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.HumanFlowLayoutPanel.Size = new System.Drawing.Size(786, 416);
            this.HumanFlowLayoutPanel.TabIndex = 0;
            // 
            // HumanNameTextBox
            // 
            this.HumanNameTextBox.Location = new System.Drawing.Point(8, 8);
            this.HumanNameTextBox.Name = "HumanNameTextBox";
            this.HumanNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.HumanNameTextBox.TabIndex = 0;
            this.HumanNameTextBox.Text = "Name";
            // 
            // HumanDescriptionTextBox
            // 
            this.HumanDescriptionTextBox.Location = new System.Drawing.Point(114, 8);
            this.HumanDescriptionTextBox.Name = "HumanDescriptionTextBox";
            this.HumanDescriptionTextBox.Size = new System.Drawing.Size(100, 23);
            this.HumanDescriptionTextBox.TabIndex = 1;
            this.HumanDescriptionTextBox.Text = "Description";
            // 
            // AttributesTab
            // 
            this.AttributesTab.Controls.Add(this.AttributesFlowLayoutPanel);
            this.AttributesTab.Location = new System.Drawing.Point(4, 24);
            this.AttributesTab.Name = "AttributesTab";
            this.AttributesTab.Padding = new System.Windows.Forms.Padding(3);
            this.AttributesTab.Size = new System.Drawing.Size(792, 422);
            this.AttributesTab.TabIndex = 1;
            this.AttributesTab.Text = "Attributes";
            this.AttributesTab.UseVisualStyleBackColor = true;
            // 
            // AttributesFlowLayoutPanel
            // 
            this.AttributesFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesIsAliveCheckBox);
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesIsAttackableCheckBox);
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesMeleeNumericUpDown);
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesRangeNumericUpDown);
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesSturdinessNumericUpDown);
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesResistanceNumericUpDown);
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesAgilityNumericUpDown);
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesIntelligenceNumericUpDown);
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesAttacksNumericUpDown);
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesHealthNumericUpDown);
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesSpeedNumericUpDown);
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesStrengthNumericUpDown);
            this.AttributesFlowLayoutPanel.Controls.Add(this.AttributesMagicNumericUpDown);
            this.AttributesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttributesFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.AttributesFlowLayoutPanel.Name = "AttributesFlowLayoutPanel";
            this.AttributesFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.AttributesFlowLayoutPanel.Size = new System.Drawing.Size(786, 416);
            this.AttributesFlowLayoutPanel.TabIndex = 0;
            // 
            // AttributesIsAliveCheckBox
            // 
            this.AttributesIsAliveCheckBox.AutoSize = true;
            this.AttributesIsAliveCheckBox.Checked = true;
            this.AttributesIsAliveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AttributesIsAliveCheckBox.Location = new System.Drawing.Point(8, 8);
            this.AttributesIsAliveCheckBox.Name = "AttributesIsAliveCheckBox";
            this.AttributesIsAliveCheckBox.Size = new System.Drawing.Size(61, 19);
            this.AttributesIsAliveCheckBox.TabIndex = 0;
            this.AttributesIsAliveCheckBox.Text = "Is alive";
            this.AttributesIsAliveCheckBox.UseVisualStyleBackColor = true;
            // 
            // AttributesIsAttackableCheckBox
            // 
            this.AttributesIsAttackableCheckBox.AutoSize = true;
            this.AttributesIsAttackableCheckBox.Checked = true;
            this.AttributesIsAttackableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AttributesIsAttackableCheckBox.Location = new System.Drawing.Point(75, 8);
            this.AttributesIsAttackableCheckBox.Name = "AttributesIsAttackableCheckBox";
            this.AttributesIsAttackableCheckBox.Size = new System.Drawing.Size(91, 19);
            this.AttributesIsAttackableCheckBox.TabIndex = 1;
            this.AttributesIsAttackableCheckBox.Text = "Is attackable";
            this.AttributesIsAttackableCheckBox.UseVisualStyleBackColor = true;
            // 
            // AttributesMeleeNumericUpDown
            // 
            this.AttributesMeleeNumericUpDown.Location = new System.Drawing.Point(172, 8);
            this.AttributesMeleeNumericUpDown.Name = "AttributesMeleeNumericUpDown";
            this.AttributesMeleeNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.AttributesMeleeNumericUpDown.TabIndex = 2;
            // 
            // AttributesRangeNumericUpDown
            // 
            this.AttributesRangeNumericUpDown.Location = new System.Drawing.Point(298, 8);
            this.AttributesRangeNumericUpDown.Name = "AttributesRangeNumericUpDown";
            this.AttributesRangeNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.AttributesRangeNumericUpDown.TabIndex = 3;
            // 
            // AttributesSturdinessNumericUpDown
            // 
            this.AttributesSturdinessNumericUpDown.Location = new System.Drawing.Point(424, 8);
            this.AttributesSturdinessNumericUpDown.Name = "AttributesSturdinessNumericUpDown";
            this.AttributesSturdinessNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.AttributesSturdinessNumericUpDown.TabIndex = 4;
            // 
            // AttributesResistanceNumericUpDown
            // 
            this.AttributesResistanceNumericUpDown.Location = new System.Drawing.Point(550, 8);
            this.AttributesResistanceNumericUpDown.Name = "AttributesResistanceNumericUpDown";
            this.AttributesResistanceNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.AttributesResistanceNumericUpDown.TabIndex = 5;
            // 
            // AttributesAgilityNumericUpDown
            // 
            this.AttributesAgilityNumericUpDown.Location = new System.Drawing.Point(8, 37);
            this.AttributesAgilityNumericUpDown.Name = "AttributesAgilityNumericUpDown";
            this.AttributesAgilityNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.AttributesAgilityNumericUpDown.TabIndex = 6;
            // 
            // AttributesIntelligenceNumericUpDown
            // 
            this.AttributesIntelligenceNumericUpDown.Location = new System.Drawing.Point(134, 37);
            this.AttributesIntelligenceNumericUpDown.Name = "AttributesIntelligenceNumericUpDown";
            this.AttributesIntelligenceNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.AttributesIntelligenceNumericUpDown.TabIndex = 7;
            // 
            // AttributesAttacksNumericUpDown
            // 
            this.AttributesAttacksNumericUpDown.Location = new System.Drawing.Point(260, 37);
            this.AttributesAttacksNumericUpDown.Name = "AttributesAttacksNumericUpDown";
            this.AttributesAttacksNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.AttributesAttacksNumericUpDown.TabIndex = 8;
            // 
            // AttributesHealthNumericUpDown
            // 
            this.AttributesHealthNumericUpDown.Location = new System.Drawing.Point(386, 37);
            this.AttributesHealthNumericUpDown.Name = "AttributesHealthNumericUpDown";
            this.AttributesHealthNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.AttributesHealthNumericUpDown.TabIndex = 9;
            // 
            // AttributesSpeedNumericUpDown
            // 
            this.AttributesSpeedNumericUpDown.Location = new System.Drawing.Point(512, 37);
            this.AttributesSpeedNumericUpDown.Name = "AttributesSpeedNumericUpDown";
            this.AttributesSpeedNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.AttributesSpeedNumericUpDown.TabIndex = 10;
            // 
            // AttributesStrengthNumericUpDown
            // 
            this.AttributesStrengthNumericUpDown.Location = new System.Drawing.Point(638, 37);
            this.AttributesStrengthNumericUpDown.Name = "AttributesStrengthNumericUpDown";
            this.AttributesStrengthNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.AttributesStrengthNumericUpDown.TabIndex = 11;
            // 
            // AttributesMagicNumericUpDown
            // 
            this.AttributesMagicNumericUpDown.Location = new System.Drawing.Point(8, 66);
            this.AttributesMagicNumericUpDown.Name = "AttributesMagicNumericUpDown";
            this.AttributesMagicNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.AttributesMagicNumericUpDown.TabIndex = 12;
            // 
            // AddNewEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNewEntityTabControl);
            this.Name = "AddNewEntity";
            this.Text = "AddNewEntity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewEntity_FormClosing);
            this.AddNewEntityTabControl.ResumeLayout(false);
            this.HumanTab.ResumeLayout(false);
            this.HumanFlowLayoutPanel.ResumeLayout(false);
            this.HumanFlowLayoutPanel.PerformLayout();
            this.AttributesTab.ResumeLayout(false);
            this.AttributesFlowLayoutPanel.ResumeLayout(false);
            this.AttributesFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesMeleeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesRangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesSturdinessNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesResistanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesAgilityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesIntelligenceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesAttacksNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesHealthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesSpeedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesStrengthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesMagicNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl AddNewEntityTabControl;
        private TabPage HumanTab;
        private TabPage AttributesTab;
        private FlowLayoutPanel HumanFlowLayoutPanel;
        private TextBox HumanNameTextBox;
        private TextBox HumanDescriptionTextBox;
        private FlowLayoutPanel AttributesFlowLayoutPanel;
        private CheckBox AttributesIsAliveCheckBox;
        private CheckBox AttributesIsAttackableCheckBox;
        private NumericUpDown AttributesMeleeNumericUpDown;
        private NumericUpDown AttributesRangeNumericUpDown;
        private NumericUpDown AttributesSturdinessNumericUpDown;
        private NumericUpDown AttributesResistanceNumericUpDown;
        private NumericUpDown AttributesAgilityNumericUpDown;
        private NumericUpDown AttributesIntelligenceNumericUpDown;
        private NumericUpDown AttributesAttacksNumericUpDown;
        private NumericUpDown AttributesHealthNumericUpDown;
        private NumericUpDown AttributesSpeedNumericUpDown;
        private NumericUpDown AttributesStrengthNumericUpDown;
        private NumericUpDown AttributesMagicNumericUpDown;
    }
}
using AutoBattlerSharp.GUI;

namespace AutoBattlerSharp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
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
            {
                RichTextBox textBox = new RichTextBox();
                textBox.Text = closedForm.Human.ToString();
                textBox.Dock = DockStyle.Top;
                HorizontalSplitContainer.Panel1.Controls.Add(textBox);
            }
        }
    }
}
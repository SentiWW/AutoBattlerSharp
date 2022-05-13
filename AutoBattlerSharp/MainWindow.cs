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
            MessageBox.Show(closedForm.Return.ToString());
        }
    }
}
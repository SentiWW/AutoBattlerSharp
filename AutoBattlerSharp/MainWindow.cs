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

            addNewEntityWindow.Show();
        }
    }
}
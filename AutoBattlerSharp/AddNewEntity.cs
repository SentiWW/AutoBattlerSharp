using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBattlerSharp.GUI
{
    public partial class AddNewEntity : Form
    {
        public int? Return { get; set; }

        public AddNewEntity()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Return = (int)numericUpDown1.Value;
        }
    }
}

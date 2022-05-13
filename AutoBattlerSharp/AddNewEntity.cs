using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoBattlerSharp.Logic.Models;

namespace AutoBattlerSharp.GUI
{
    public partial class AddNewEntity : Form
    {
        public Human? Human { get; set; }

        public AddNewEntity()
        {
            InitializeComponent();
        }

        private void AddNewEntity_FormClosing(object sender, FormClosingEventArgs e)
        {
            Attributes attributes = new Attributes();
            attributes.IsAlive = AttributesIsAliveCheckBox.Checked;
            attributes.IsAttackable = AttributesIsAttackableCheckBox.Checked;
            attributes.Melee = (byte)AttributesMeleeNumericUpDown.Value;
            attributes.Range = (byte)AttributesRangeNumericUpDown.Value;
            attributes.Sturdiness = (byte)AttributesSturdinessNumericUpDown.Value;
            attributes.Resistance = (byte)AttributesResistanceNumericUpDown.Value;
            attributes.Agility = (byte)AttributesAgilityNumericUpDown.Value;
            attributes.Intelligence = (byte)AttributesIntelligenceNumericUpDown.Value;
            attributes.Attacks = (byte)AttributesAttacksNumericUpDown.Value;
            attributes.Health = (byte)AttributesHealthNumericUpDown.Value;
            attributes.Speed = (byte)AttributesSpeedNumericUpDown.Value;
            attributes.Strength = (byte)AttributesStrengthNumericUpDown.Value;
            attributes.Magic = (byte)AttributesMagicNumericUpDown.Value;

            string name = HumanNameTextBox.Text;
            string description = HumanDescriptionTextBox.Text;
            Human = new Human(name, description, new Attributes(attributes));
        }
    }
}

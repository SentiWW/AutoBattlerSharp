using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutoBattlerSharp.Logic.Models;
using AutoBattlerSharp.Logic.Models.Items;
using AutoBattlerSharp.Logic.Models.Items.Armours;

namespace AutoBattlerSharp.Logic.Tests.Models.Items.Armours
{
    public class PlateArmourTest
    {
        [Fact]
        public void GetDefenceTest()
        {
            Attributes attributes = new Attributes();
            attributes.Resistance = 10;

            IArmour armour = new PlateArmour("Armour", "Test armour", 50, 10, 12);

            Assert.Equal(32, armour.GetDefence(attributes));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutoBattlerSharp.Logic.Models;
using AutoBattlerSharp.Logic.Models.Items.Weapons;


namespace AutoBattlerSharp.Logic.Tests.Models.Items.Weapons
{
    public class MagicWandTest
    {
        [Fact]
        public void GetAttackDamageTest()
        {
            Attributes attributes = new Attributes();
            attributes.Magic = 2;

            IWeapon wand = new MagicWand("Wand", "Wand of tests", 100, 5, 5);

            Assert.Equal(10, wand.GetAttackDamage(attributes));

        }

    }
}

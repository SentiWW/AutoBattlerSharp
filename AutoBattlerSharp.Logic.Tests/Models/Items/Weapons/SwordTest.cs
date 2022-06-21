using Xunit;
using AutoBattlerSharp.Logic.Models;
using AutoBattlerSharp.Logic.Models.Items.Weapons;


namespace AutoBattlerSharp.Logic.Tests.Models.Items.Weapons
{
    public class SwordTest
    {
        [Fact]
        public void GetAttackDamageTest()
        {
            Attributes attributes = new Attributes();
            attributes.Attacks = 1;
            attributes.Sturdiness = 2;
            attributes.Strength = 3;

            IWeapon sword = new Sword("Sword", "Test Sword", 10, 10, 4, 0.5F);

            Assert.Equal(9, sword.GetAttackDamage(attributes));
        }

    }
}
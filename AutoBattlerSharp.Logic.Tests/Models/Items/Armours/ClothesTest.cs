using Xunit;
using AutoBattlerSharp.Logic.Models;
using AutoBattlerSharp.Logic.Models.Items.Armours;

namespace AutoBattlerSharp.Logic.Tests.Models.Items.Armours
{
    public class ClothesTest
    {
        [Fact]
        public void GetDefenceTest()
        {
            Attributes attributes = new Attributes();
            attributes.Resistance = 5;
            
            IArmour armour = new Clothes("Clothes", "Test Clothes", 10, 5, 2);
            
            Assert.Equal(7, armour.GetDefence(attributes));
        }

    }
}

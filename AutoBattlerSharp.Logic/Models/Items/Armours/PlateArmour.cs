using System.Text.Json.Serialization;

namespace AutoBattlerSharp.Logic.Models.Items.Armours
{
    public class PlateArmour : Armour, IArmour
    {
        public PlateArmour(string name, string description, short value, short weight, short defencePoints)
            : base(name, description, value, weight, defencePoints)
        {

        }

        [JsonConstructor]
        public PlateArmour()
        {

        }

        public new short GetDefence(Attributes attributes)
        {
            return (short)(base.GetDefence(attributes) + 2 * attributes.Resistance);
        }
    }
}

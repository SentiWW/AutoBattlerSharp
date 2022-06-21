using System.Text.Json.Serialization;

namespace AutoBattlerSharp.Logic.Models.Items.Armours
{
    public class Clothes : Armour, IArmour
    {
        public Clothes(string name, string description, short value, short weight, short defencePoints)
            : base(name, description, value, weight, defencePoints)
        {

        }

        [JsonConstructor]
        public Clothes()
        {

        }

        public new short GetDefence(Attributes attributes)
        {
            return (short)(base.GetDefence(attributes) + attributes.Resistance);
        }

    }
}

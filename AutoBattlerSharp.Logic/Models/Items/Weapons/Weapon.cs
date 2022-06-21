using System.Text.Json.Serialization;

namespace AutoBattlerSharp.Logic.Models.Items.Weapons
{
    public class Weapon : Item, IWeapon
    {
        [JsonPropertyName("attackpoints")]
        [JsonInclude]
        public short AttackPoints { get; set; }
        [JsonPropertyName("accuracy")]
        [JsonInclude]
        public float Accuracy { get; set; }

        [JsonConstructor]
        public Weapon()
        {

        }

        public Weapon(string name, string description, short value, short weight, short attackPoints) : base(name, description, value, weight)
        {
            AttackPoints = attackPoints;
            Accuracy = 1;
        }

        public short GetAttackDamage(Attributes attributes)
        {
            return attributes.Strength;
        }
    }
}

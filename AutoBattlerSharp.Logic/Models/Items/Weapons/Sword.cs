using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models.Items.Weapons
{
    public class Sword : Weapon, IWeapon
    {
        [JsonConstructor]
        public Sword()
        {

        }

        public Sword(string name, string description, short value, short weight, short attackPoints, float accuracy) : base(name, description, value, weight, attackPoints)
        {
            Accuracy = accuracy;
        }

        public new short GetAttackDamage(Attributes attributes)
        {
            int attackDamage = 0;

            Random rnd = new Random();

            if (rnd.NextDouble() < Accuracy)
            {
                attackDamage += AttackPoints * attributes.Attacks + attributes.Sturdiness + attributes.Strength;
            }
            return (short)attackDamage;
        }
    }
}

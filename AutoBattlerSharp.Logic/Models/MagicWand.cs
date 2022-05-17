using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    public class MagicWand : Item, IWeapon
    {
        public short AttackPoints { get; set; }
        public float Accuracy { get; set; }

        public MagicWand(string name, string description, short value, short weight, short attackPoints) : base(name, description, value, weight)
        {
            AttackPoints = attackPoints;
            Accuracy = 1;
        }

        public short GetAttackDamage(Attributes attributes)
        {
            int attackDamage = 0;
            attackDamage += AttackPoints * attributes.Magic;
            return (short) attackDamage;
        }
    }
}

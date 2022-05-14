using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    public class MagicWand : Item, IWeapon
    {
        public byte MinIntelligence { get; set; }
        public byte AttackPoints { get; set; }
        public float Accuracy { get; set; }

        public MagicWand(string name, string description, byte value, byte weight, byte minIntelligence, byte attackPoints) : base(name, description, value, weight)
        {
            MinIntelligence = minIntelligence;
            AttackPoints = attackPoints;
            Accuracy = 1;
        }

        public byte GetAttackDamage(byte attack, byte magic, byte sturdiness, byte strength, byte intelligence)
        {
            int attackDamage = 0;
            if(intelligence >= MinIntelligence)
            {
                attackDamage += AttackPoints * magic;
            }
            return (byte) attackDamage;
        }
    }
}

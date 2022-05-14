using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    public class Sword : Item, IWeapon
    {
        public byte AttackPoints { get; set; }
        public float Accuracy { get; set; }


        public Sword(string name, string description, byte value, byte weight, byte attackPoints, float accuracy) : base(name, description, value, weight)
        {
            AttackPoints = attackPoints;
            Accuracy = accuracy;
        }

 
        public byte GetAttackDamage(byte attack, byte magic, byte sturdiness, byte strength, byte intelligence)
        {
            int attackDamage = 0;

            Random rnd = new Random();

            if (rnd.NextDouble() < Accuracy)
            {
                attackDamage += AttackPoints * (sturdiness + strength) + attack;
            }
            return (byte) attackDamage;
        }
    }
}

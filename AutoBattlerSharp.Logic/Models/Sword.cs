using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    public class Sword : Item, IWeapon
    {
        public short AttackPoints { get; set; }
        public float Accuracy { get; set; }


        public Sword(string name, string description, short value, short weight, short attackPoints, float accuracy) : base(name, description, value, weight)
        {
            AttackPoints = attackPoints;
            Accuracy = accuracy;
        }

 
        public short GetAttackDamage(short attack, short magic, short sturdiness, short strength, short intelligence)
        {
            int attackDamage = 0;

            Random rnd = new Random();

            if (rnd.NextDouble() < Accuracy)
            {
                attackDamage += AttackPoints * (sturdiness + strength) + attack;
            }
            return (short) attackDamage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    public interface IWeapon
    {
        public byte AttackPoints { get; set; }
        public float Accuracy { get; set; }

        public byte GetAttackDamage(byte attack, byte magic, byte sturdiness, byte strength, byte intelligence);

    }
}

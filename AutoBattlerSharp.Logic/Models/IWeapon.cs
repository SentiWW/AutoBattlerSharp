using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    public interface IWeapon
    {
        public short AttackPoints { get; set; }
        public float Accuracy { get; set; }

        public short GetAttackDamage(short attack, short magic, short sturdiness, short strength, short intelligence);

    }
}

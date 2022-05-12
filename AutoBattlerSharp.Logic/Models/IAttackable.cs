using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    internal interface IAttackable
    {
        public byte GetTotalAttack();
        public byte GetTotalDefence();
        public void Attack(IAttackable target);
    }
}

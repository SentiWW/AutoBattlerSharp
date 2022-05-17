using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    public interface IAttackable
    {
        public Attributes Attributes { get; set; }
        public short GetTotalAttack(ref FightInfo info);
        public short GetTotalDefence(ref FightInfo info);
        public FightInfo Attack(IAttackable target, FightInfo info);
    }
}

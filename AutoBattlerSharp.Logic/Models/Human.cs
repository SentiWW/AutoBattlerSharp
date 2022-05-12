using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    internal class Human : Creature, IAttackable
    {
        public Human(string name, string description, Attributes attributes) : base(name, description, attributes)
        {

        }

        public void Attack(IAttackable target)
        {
            throw new NotImplementedException();
        }

        public byte GetTotalAttack()
        {
            throw new NotImplementedException();
        }

        public byte GetTotalDefence()
        {
            throw new NotImplementedException();
        }
    }
}

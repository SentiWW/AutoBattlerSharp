using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models.Items
{
    public class MagicWand : Weapon, IWeapon
    {

        [JsonConstructor]
        public MagicWand()
        {

        }

        public MagicWand(string name, string description, short value, short weight, short attackPoints) 
            : base(name, description, value, weight, attackPoints)
        {

        }

        public new short GetAttackDamage(Attributes attributes, FightInfo info)
        {
            int attackDamage = 0;
            attackDamage += AttackPoints * attributes.Magic;
            return (short)attackDamage;
        }
    }
}

﻿using System.Text.Json.Serialization;

namespace AutoBattlerSharp.Logic.Models.Items.Weapons
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

        public new short GetAttackDamage(Attributes attributes)
        {
            int attackDamage = 0;
            attackDamage += AttackPoints * attributes.Magic;
            return (short)attackDamage;
        }
    }
}

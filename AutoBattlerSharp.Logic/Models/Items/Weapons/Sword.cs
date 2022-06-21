﻿using System.Text.Json.Serialization;

namespace AutoBattlerSharp.Logic.Models.Items.Weapons
{
    public class Sword : Weapon, IWeapon
    {
        [JsonConstructor]
        public Sword()
        {

        }

        public Sword(string name, string description, short value, short weight, short attackPoints, float accuracy) : base(name, description, value, weight, attackPoints)
        {
            Accuracy = accuracy;
        }

        public new short GetAttackDamage(Attributes attributes)
        {
            int attackDamage = 0;
            attackDamage += AttackPoints * attributes.Attacks + attributes.Sturdiness + attributes.Strength;
            return (short)attackDamage;
        }
    }
}

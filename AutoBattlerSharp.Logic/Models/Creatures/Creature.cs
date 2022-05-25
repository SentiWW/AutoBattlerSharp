﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models.Creatures
{
    public abstract class Creature : Entity, IAttackable
    {
        public Attributes Attributes { get; set; }

        [JsonConstructor]
        public Creature()
        {

        }

        public Creature(string name, string description, Attributes attributes) : base(name, description)
        {
            Attributes = attributes;

            if (Attributes.Health <= 0)
            {
                Attributes.IsAlive = false;
                Attributes.IsAttackable = false;
            }
        }

        public Creature(Creature creature) : base(creature.Name, creature.Description)
        {
            Attributes = new Attributes(creature.Attributes);
        }

        public override string ToString()
        {
            return $"Creature:\n" +
                   $"\tId: {Id}\n" +
                   $"\tName: {Name}\n" +
                   $"\tDescription: {Description}\n" +
                   Attributes.ToString();
        }

        public FightInfo Attack(IAttackable target, FightInfo info)
        {
            CheckValidTarget(target, info);

            short damage = (short)(GetTotalAttack(ref info) - GetTotalDefence(ref info));

            if (damage <= 0)
            {
                info.Information += $"{Name} tried to attack {((Entity)target).Name} but they didn't deal any damage!\n";
                return info;
            }

            target.Attributes.Health -= damage;
            info.Information += $"{Name} attacks {((Entity)target).Name} dealing {damage} damage!\n";

            CheckIfTargetDied(target, info);
            return info;
        }

        protected FightInfo CheckValidTarget(IAttackable target, FightInfo info)
        {
            if (!target.Attributes.IsAttackable)
            {
                info.Information += $"{Name} tried to attack {((Entity)target).Name} but they are unattackable!\n";
                return info;
            }

            if (!target.Attributes.IsAlive)
            {
                info.Information += $"{Name} tried to attack {((Entity)target).Name} but they are dead!\n";
                return info;
            }

            return info;
        }

        protected FightInfo CheckIfTargetDied(IAttackable target, FightInfo info)
        {
            if (target.Attributes.Health > 0)
                return info;

            target.Attributes.IsAttackable = false;
            target.Attributes.IsAlive = false;
            info.Information += $"{((Entity)target).Name} dies!\n";
            return info;
        }

        public short GetTotalAttack(ref FightInfo info)
        {
            short accuracy = (short)_random.Next(0, 100);

            if (accuracy > 90)
            {
                info.Information += $"{Name} missed!\n";

                return 0;
            }

            short totalAttack = Attributes.Strength;

            return totalAttack;
        }

        public short GetTotalDefence(ref FightInfo info)
        {
            short totalDefence = (short)(Math.Sqrt(Attributes.Strength) +
                                         Math.Sqrt(Attributes.Resistance) +
                                         Math.Sqrt(Attributes.Sturdiness));

            return totalDefence;
        }
    }
}

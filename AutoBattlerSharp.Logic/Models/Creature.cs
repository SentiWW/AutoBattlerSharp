using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    public abstract class Creature : Entity, IAttackable
    {
        public Attributes Attributes { get; set; }

        public Creature(string name, string description, Attributes attributes) : base(name, description)
        {
            Attributes = attributes;
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
            if(!target.Attributes.IsAttackable)
            {
                info.Information += $"{Name} tried to attack {((Entity)target).Name} but they are unattackable!\n";
                return info;
            }

            if (!target.Attributes.IsAlive)
            {
                info.Information += $"{Name} tried to attack {((Entity)target).Name} but they are dead!\n";
                return info;
            }

            short damage = (short)(GetTotalAttack(ref info) - GetTotalDefence(ref info));

            if (damage <= 0)
            {
                info.Information += $"{Name} tried to attack {((Entity)target).Name} but they didn't deal any damage!\n";
                return info;
            }

            target.Attributes.Health -= damage;
            info.Information += $"{Name} attacks {((Entity)target).Name} dealing {damage} damage!\n";

            if (target.Attributes.Health <= 0)
            {
                target.Attributes.IsAttackable = false;
                target.Attributes.IsAlive = false;
                info.Information += $"{((Entity)target).Name} dies!\n";
            }

            return info;
        }

        public short GetTotalAttack(ref FightInfo info)
        {
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

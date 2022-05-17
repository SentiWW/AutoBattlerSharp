using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    public class Human : Creature, IAttackable
    {
        IWeapon? Weapon;

        [JsonConstructor]
        public Human()
        {

        }

        public Human(string name, string description, Attributes attributes, IWeapon? weapon = null) : base(name, description, attributes)
        {
            Weapon = weapon;
        }

        public Human(Human human) : base(human.Name, human.Description, human.Attributes)
        {
            Weapon = human.Weapon;
        }

        public new FightInfo Attack(IAttackable target, FightInfo info)
        {
            short bonusDamage = 0;

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

            short enemyDodge = (short)_random.Next(0, 100);

            if(enemyDodge <= target.Attributes.Agility / 2)
            {
                info.Information += $"{((Entity)target).Name} managed to dodge {Name}'s attack!\n";
                return info;
            }
            if(95 <= enemyDodge && enemyDodge <= 100)
            {
                info.Information += $"{((Entity)target).Name} tripped and fell while dodging {Name}'s attack!\n";
                bonusDamage = 5;
            }    


            short damage = (short)(bonusDamage + GetTotalAttack(ref info) - GetTotalDefence(ref info));

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

        public new short GetTotalAttack(ref FightInfo info)
        {
            short accuracy = (short)_random.Next(0, 100);

            if(accuracy > 90)
            {
                info.Information += $"{Name} missed!\n";

                return 0;
            }

            short totalAttack = Attributes.Strength;

            return totalAttack;
        }

        public new short GetTotalDefence(ref FightInfo info)
        {
            short totalDefence = (short)(Math.Sqrt(Attributes.Strength) +
                                       Math.Sqrt(Attributes.Resistance) +
                                       Math.Sqrt(Attributes.Sturdiness));

            return totalDefence;
        }

        public override string ToString()
        {
            return $"Human:\n" +
                   $"\tId: {Id}\n" +
                   $"\tName: {Name}\n" +
                   $"\tDescription: {Description}\n" +
                   Attributes.ToString() +
                   (Weapon is not null ? Weapon.ToString() : "");
        }
    }
}

using AutoBattlerSharp.Logic.Models.Items.Armours;
using AutoBattlerSharp.Logic.Models.Items.Weapons;
using System.Text.Json.Serialization;

namespace AutoBattlerSharp.Logic.Models.Creatures
{
    public class Human : Creature, IAttackable
    {
        [JsonPropertyName("armour")]
        [JsonInclude]
        public Armour? Armour; 

        [JsonPropertyName("weapon")]
        [JsonInclude]
        public Weapon? Weapon = null;

        [JsonConstructor]
        public Human()
        {

        }

        public Human(string name, string description, Attributes attributes, Weapon? weapon = null) : base(name, description, attributes)
        {
            Weapon = weapon;
        }

        public Human(Human human) : base(human.Name, human.Description, human.Attributes)
        {
            Weapon = human.Weapon;
        }

        public new FightInfo Attack(IAttackable target, FightInfo info)
        {
            if (Weapon is null)
                return base.Attack(target, info);

            CheckValidTarget(target, info);

            short attack = GetTotalAttack();
            short defence = GetTotalDefence();

            if (attack == short.MinValue)
            {
                info.FightOutcome = FightOutcomes.Missed;
                return info;
            }

            short damage = (short)(attack - defence);

            info.Damage = damage;

            if (damage < 0)
            {
                info.FightOutcome = FightOutcomes.LessThanZeroDamage;
                return info;
            }

            if (damage == 0)
            {
                info.FightOutcome = FightOutcomes.ZeroDamage;
                return info;
            }

            if (damage < 10)
                info.FightOutcome = FightOutcomes.LessThanTenDamage;

            if (damage >= 10)
                info.FightOutcome = FightOutcomes.OverOrTenDamage;

            target.Attributes.Health -= damage;
            info.Information += $"{Name} attacks {((Entity)target).Name} dealing {damage} damage!\n";

            CheckIfTargetDied(target, info);
            return info;
        }

        public new short GetTotalAttack()
        {
            short accuracy = (short)_random.Next(0, 100);

            if (accuracy > 90)
                return short.MinValue;

            short totalAttack = Attributes.Strength;

            if (!(Weapon is null))
               totalAttack += Weapon.GetAttackDamage(Attributes);

            if (accuracy < 10)
                totalAttack *= 2;

            return totalAttack;
        }

        public new short GetTotalDefence()
        {
            short totalDefence = (short)(Math.Sqrt(Attributes.Strength) +
                                       Math.Sqrt(Attributes.Resistance) +
                                       Math.Sqrt(Attributes.Sturdiness));

            if (Armour is null)
                return totalDefence;

            totalDefence += Armour.GetDefence(Attributes);

            return totalDefence;
        }

        public override string ToString()
        {
            return $"Human:\n" +
                   $"\tId: {Id}\n" +
                   $"\tName: {Name}\n" +
                   $"\tDescription: {Description}\n" +
                   Attributes.ToString() +
                   (Weapon is not null ? Weapon.ToString() : "") +
                   (Armour is not null ? Armour.ToString() : "");
        }
    }
}

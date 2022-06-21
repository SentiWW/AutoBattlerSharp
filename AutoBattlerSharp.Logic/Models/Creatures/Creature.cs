using System.Text.Json.Serialization;

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

            if(damage == 0)
            {
                info.FightOutcome = FightOutcomes.ZeroDamage;
                return info;
            }

            if(damage < 10)
                info.FightOutcome = FightOutcomes.LessThanTenDamage;

            if (damage >= 10)
                info.FightOutcome = FightOutcomes.OverOrTenDamage;

            target.Attributes.Health -= damage;
            info.Information += $"{Name} attacks {((Entity)target).Name} dealing {damage} damage!\n";

            CheckIfTargetDied(target, info);
            return info;
        }

        protected FightInfo CheckValidTarget(IAttackable target, FightInfo info)
        {
            if (!target.Attributes.IsAttackable)
            {
                info.FightOutcome = FightOutcomes.AttackedUnattackable;
                return info;
            }

            if (!target.Attributes.IsAlive)
            {
                info.FightOutcome = FightOutcomes.AttackedDead;
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
            info.FightOutcome = FightOutcomes.KillingBlow;
            return info;
        }

        public short GetTotalAttack()
        {
            short accuracy = (short)_random.Next(0, 100);

            if (accuracy > 90)
                return short.MinValue;

            short totalAttack = Attributes.Strength;

            return totalAttack;
        }

        public short GetTotalDefence()
        {
            short totalDefence = (short)(Math.Sqrt(Attributes.Strength) +
                                         Math.Sqrt(Attributes.Resistance) +
                                         Math.Sqrt(Attributes.Sturdiness));

            return totalDefence;
        }
    }
}

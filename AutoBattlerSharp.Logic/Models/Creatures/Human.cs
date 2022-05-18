using AutoBattlerSharp.Logic.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models.Creatures
{
    public class Human : Creature, IAttackable
    {
        [JsonPropertyName("armour")]
        [JsonInclude]
        public List<Armour>? ArmourPieces; 

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

            short damage = (short)(GetTotalAttack(ref info) - GetTotalDefence(ref info));

            if (damage <= 0)
            {
                info.Information += $"{Name} tried to attack {((Entity)target).Name} but they didn't deal any damage!\n";
                return info;
            }

            target.Attributes.Health -= damage;
            info.Information += $"{Name} attacks {((Entity)target).Name} with {Weapon.Name} dealing {damage} damage!\n";

            CheckIfTargetDied(target, info);
            return info;
        }

        public new short GetTotalAttack(ref FightInfo info)
        {
            short accuracy = (short)_random.Next(0, 100);

            if (accuracy > 90)
            {
                info.Information += $"{Name} missed!\n";

                return 0;
            }

            short totalAttack = Attributes.Strength;

            if (Weapon is null)
                return totalAttack;

            totalAttack += Weapon.GetAttackDamage(Attributes, info);

            return totalAttack;
        }

        public new short GetTotalDefence(ref FightInfo info)
        {
            short totalDefence = (short)(Math.Sqrt(Attributes.Strength) +
                                       Math.Sqrt(Attributes.Resistance) +
                                       Math.Sqrt(Attributes.Sturdiness));

            if (ArmourPieces is null || ArmourPieces.Count == 0)
                return totalDefence;

            foreach (Armour piece in ArmourPieces)
                totalDefence += piece.GetDefence(Attributes, info);

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
                   (ArmourPieces is not null && ArmourPieces.Count > 0 ?
                   string.Join(" ", ArmourPieces.Select(piece => piece.ToString())) :
                   "");
        }
    }
}

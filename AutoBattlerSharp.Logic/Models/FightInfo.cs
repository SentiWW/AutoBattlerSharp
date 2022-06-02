using AutoBattlerSharp.Logic.Models.Creatures;
using AutoBattlerSharp.Logic.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    public class FightInfo
    {
        internal FightOutcomes FightOutcome { get; set; }
        public Creature Attacker { get; set; } 
        public Creature Defender { get; set; } 
        public Weapon? Weapon { get; set; }
        public Armour? Armour { get; set; }
        public string Information { get; set; } = "";
        public int Damage { get; set; }
        private Random _random = new Random();

        private string GetRandomHitWordUnarmed()
        {
            List<string> words = new List<string>()
            {
                "hits",
                "punches",
                "kicks",
                "headbutts",
                "smashes",
                "slams",
                "strikes",
                "jabs",
                "thrashes",
                "wacks"
            };
            return words[_random.Next(words.Count)];
        }

        private string GetRandomHitWordWeapon()
        {
            List<string> words = new List<string>()
            { 
                "hits",
                "slashes",
                "cuts",
                "bashes",
                "pierces",
                "bruises",
                "slits",
                "lacerates",
                "wounds",
                "injures",
                "scratches",
                "notches",
                "chops"
            };
            return words[_random.Next(words.Count)];
        }

        public string GetFightMessage()
        {
            switch (FightOutcome)
            {
                case FightOutcomes.LessThanZeroDamage:
                    Information = $"{Attacker.Name} completely misses {Defender.Name}!\n";
                    break;

                case FightOutcomes.ZeroDamage:
                    Information = $"{Attacker.Name} {GetRandomHitWordUnarmed()} {Defender.Name} so lightly it deals no damage!\n";
                    if (Weapon is not null)
                        Information = $"{Attacker.Name} {GetRandomHitWordWeapon()} {Defender.Name} with {Weapon.Name} so lightly it deals no damage!\n";
                    if (Weapon is not null && Armour is not null)
                        Information = $"{Attacker.Name} {GetRandomHitWordWeapon()} {Defender.Name} with {Weapon.Name} but it bounces off {Defender.Name}'s {Armour} dealing no damage!\n";
                    break;

                case FightOutcomes.LessThanTenDamage:
                    Information = $"{Attacker.Name} {GetRandomHitWordUnarmed()} {Defender.Name} dealing {Damage} damage!\n";
                    if (Weapon is not null)
                        Information = $"{Attacker.Name} {GetRandomHitWordWeapon()} {Defender.Name} with {Weapon.Name} dealing {Damage} damage!\n";
                    break;

                case FightOutcomes.OverOrTenDamage:
                    Information = $"{Attacker.Name} {GetRandomHitWordUnarmed()} {Defender.Name} dealing {Damage} damage!\n";
                    if (Weapon is not null)
                        Information = $"{Attacker.Name} {GetRandomHitWordWeapon()} {Defender.Name} with {Weapon.Name} dealing {Damage} damage!\n";
                    break;

                case FightOutcomes.DamageWithBonus:
                    break;

                case FightOutcomes.KillingBlow:
                    Information = $"{Attacker.Name} {GetRandomHitWordUnarmed()} {Defender.Name} dealing {Damage} damage, killing them!\n";
                    if (Weapon is not null)
                        Information = $"{Attacker.Name} {GetRandomHitWordWeapon()} {Defender.Name} with {Weapon.Name} dealing {Damage} damage, killing them!\n";
                    break;

                case FightOutcomes.AttackedUnattackable:
                    Information = $"{Attacker.Name} {GetRandomHitWordUnarmed()} {Defender.Name} but they are unattackable!";
                    break;

                case FightOutcomes.AttackedDead:
                    Information = $"{Attacker.Name} {GetRandomHitWordUnarmed()} {Defender.Name} but they are already dead!";
                    break;

                case FightOutcomes.Missed:
                    Information = $"{Attacker.Name} {GetRandomHitWordUnarmed()} {Defender.Name} but misses them!\n";
                    if (Weapon is not null)
                        Information = $"{Attacker.Name} {GetRandomHitWordWeapon()} {Defender.Name} with {Weapon.Name} but misses them!!\n";
                    break;
            }

            return Information;
        }
    }
}

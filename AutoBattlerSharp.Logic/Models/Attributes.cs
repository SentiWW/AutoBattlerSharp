using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    public class Attributes
    {
        public bool IsAlive { get; set; }
        public bool IsAttackable { get; set; }
        public short Melee { get; set; }
        public short Range { get; set; }
        public short Sturdiness { get; set; }
        public short Resistance { get; set; }
        public short Agility { get; set; }
        public short Intelligence { get; set; }
        public short Attacks { get; set; }
        public short Health { get; set; }
        public short MaxHealth { get; set; }
        public short Speed { get; set; }
        public short Strength { get; set; }
        public short Magic { get; set; }

        public Attributes()
        {

        }

        public Attributes(Attributes attributes)
        {
            IsAlive = attributes.IsAlive;
            IsAttackable = attributes.IsAttackable;
            Melee = attributes.Melee;
            Range = attributes.Range;
            Sturdiness = attributes.Sturdiness;
            Resistance = attributes.Resistance;
            Agility = attributes.Agility;
            Intelligence = attributes.Intelligence;
            Attacks = attributes.Attacks;
            Health = attributes.Health;
            MaxHealth = attributes.MaxHealth;
            Speed = attributes.Speed;
            Strength = attributes.Strength;
            Magic = attributes.Magic;
        }

        public override string ToString()
        {
            return $"Attributes:\n" +
                   $"\tIsAlive: {IsAlive}\n" +
                   $"\tIsAttackable: {IsAttackable}\n" +
                   $"\tMelee: {Melee}\n" +
                   $"\tRange: {Range}\n" +
                   $"\tSturdiness: {Sturdiness}\n" +
                   $"\tResistance: {Resistance}\n" +
                   $"\tAgility: {Agility}\n" +
                   $"\tIntelligence: {Intelligence}\n" +
                   $"\tAttacks: {Attacks}\n" +
                   $"\tHealth: {Health}\n" +
                   $"\tMaxHealth: {MaxHealth}\n" +
                   $"\tSpeed: {Speed}\n" +
                   $"\tStrength: {Strength}\n" +
                   $"\tMagic: {Magic}";
        }
    }
}

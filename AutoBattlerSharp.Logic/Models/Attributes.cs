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
        public byte Melee { get; set; }
        public byte Range { get; set; }
        public byte Sturdiness { get; set; }
        public byte Resistance { get; set; }
        public byte Agility { get; set; }
        public byte Intelligence { get; set; }
        public byte Attacks { get; set; }
        public byte Health { get; set; }
        public byte Speed { get; set; }
        public byte Strength { get; set; }
        public byte Magic { get; set; }

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
                   $"\tSpeed: {Speed}\n" +
                   $"\tStrength: {Strength}\n" +
                   $"\tMagic: {Magic}";
        }
    }
}

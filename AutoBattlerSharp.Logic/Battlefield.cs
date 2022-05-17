using AutoBattlerSharp.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic
{
    public class Battlefield
    {
        private Random _random = new Random();
        private string[] _names;
        public List<Human> Allies;
        public List<Human> Enemies;

        public Battlefield()
        {
            using (StreamReader reader = new StreamReader(@$"{AppDomain.CurrentDomain.BaseDirectory}\names.txt"))
            {
                _names = reader.ReadToEnd().Split('\n');
            }

            Attributes attributes = new Attributes()
            {
                IsAlive = true,
                IsAttackable = true,
                Melee = (byte)_random.Next(0, 100),
                Range = (byte)_random.Next(0, 100),
                Sturdiness = (byte)_random.Next(0, 100),
                Resistance = (byte)_random.Next(0, 100),
                Agility = (byte)_random.Next(0, 100),
                Intelligence = (byte)_random.Next(0, 100),
                Attacks = (byte)_random.Next(1, 2),
                Health = (byte)_random.Next(5, 30),
                Speed = (byte)_random.Next(5, 30),
                Strength = (byte)_random.Next(5, 30),
                Magic = (byte)_random.Next(5, 30)
            };
            attributes.MaxHealth = attributes.Health;

            Allies = new List<Human>();
            for (int i = 0; i < 4; i++)
            {
                attributes = new Attributes()
                {
                    IsAlive = true,
                    IsAttackable = true,
                    Melee = (short)_random.Next(0, 100),
                    Range = (short)_random.Next(0, 100),
                    Sturdiness = (short)_random.Next(0, 100),
                    Resistance = (short)_random.Next(0, 100),
                    Agility = (short)_random.Next(0, 100),
                    Intelligence = (short)_random.Next(0, 100),
                    Attacks = (short)_random.Next(1, 2),
                    Health = (short)_random.Next(5, 30),
                    Speed = (short)_random.Next(5, 30),
                    Strength = (short)_random.Next(5, 30),
                    Magic = (short)_random.Next(5, 30)
                };
                attributes.MaxHealth = attributes.Health;

                Allies.Add(new Human($"{_names[_random.Next(_names.Count())]}", $"Human {i}", new Attributes(attributes)));
            }

            Enemies = new List<Human>();
            for (int i = 0; i < 4; i++)
            {
                attributes = new Attributes()
                {
                    IsAlive = true,
                    IsAttackable = true,
                    Melee = (short)_random.Next(0, 100),
                    Range = (short)_random.Next(0, 100),
                    Sturdiness = (short)_random.Next(0, 100),
                    Resistance = (short)_random.Next(0, 100),
                    Agility = (short)_random.Next(0, 100),
                    Intelligence = (short)_random.Next(0, 100),
                    Attacks = (short)_random.Next(1, 2),
                    Health = (short)_random.Next(5, 30),
                    Speed = (short)_random.Next(5, 30),
                    Strength = (short)_random.Next(5, 30),
                    Magic = (short)_random.Next(5, 30)
                };
                attributes.MaxHealth = attributes.Health;

                Enemies.Add(new Human($"{_names[_random.Next(_names.Count())]}", $"Human {i}", new Attributes(attributes)));
            }
        }


        public FightInfo Fight()
        {
            FightInfo info = new FightInfo();

            IAttackable? ally = GetRandomAlive(Allies);
            IAttackable? enemy = GetRandomAlive(Enemies);

            if (ally is null)
            {
                info.Information += $"There were no allies left to attack.\n";
                return info;
            }

            if (enemy is null)
            {
                info.Information += $"There were no enemies left to attack.\n";
                return info;
            }

            info.Information = ally.Attack(enemy, info).Information;

            ally = GetRandomAlive(Allies);
            enemy = GetRandomAlive(Enemies);

            if (ally is null)
            {
                info.Information += $"There were no allies left to attack.\n";
                return info;
            }

            if (enemy is null)
            {
                info.Information += $"There were no enemies left to attack.\n";
                return info;
            }

            info.Information = enemy.Attack(ally, info).Information;

            return info;
        }

        private IAttackable? GetNextAlive(IEnumerable<IAttackable> fighters)
        {
            return fighters.FirstOrDefault(fighter => fighter.Attributes.IsAlive);
        }

        private IAttackable? GetRandomAlive(IEnumerable<IAttackable> fighters)
        {
            List<IAttackable> aliveFighters = fighters.Where(fighter => fighter.Attributes.IsAlive).ToList();

            if (aliveFighters.Count == 0)
                return null;

            return aliveFighters[_random.Next(aliveFighters.Count)];
        }
    }
}

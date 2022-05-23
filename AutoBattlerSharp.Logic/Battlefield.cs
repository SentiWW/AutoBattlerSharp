using AutoBattlerSharp.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using AutoBattlerSharp.Logic.Models.Creatures;
using AutoBattlerSharp.Logic.Models.Items;

namespace AutoBattlerSharp.Logic
{
    public class Battlefield
    {
        private Random _random = new Random();
        private string[] _names;

        private Queue<IAttackable> _allies;
        private Queue<IAttackable> _enemies;

        [JsonPropertyName("allies")]
        [JsonInclude]
        public List<Human> Allies;
        [JsonPropertyName("enemies")]
        [JsonInclude]
        public List<Human> Enemies;
        public bool EveryoneDied = false;

        public Battlefield()
        {
            using (StreamReader reader = new StreamReader(@$"{AppDomain.CurrentDomain.BaseDirectory}\names.txt"))
            {
                _names = reader.ReadToEnd().Trim().Replace('\r', ' ').Split("\n");
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

            Allies[0].Weapon = new Sword("Sword of Doom", "Description", 100, 5, 2, 50);
            Allies[0].ArmourPieces = new List<Armour>
            {
                new Armour("Helmet", "Helmet", 100, 50, 10),
                new Armour("Plate", "Plate", 100, 50, 20)
            };
            Allies[1].Weapon = new MagicWand("Wand of Discord", "Description", 100, 5, 2);

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

            _allies = new Queue<IAttackable>();
            _enemies = new Queue<IAttackable>();
            Allies.ForEach(ally => _allies.Enqueue(ally));
            Enemies.ForEach(enemy => _enemies.Enqueue(enemy));
        }

        public void CheckIfEitherPartyDied()
        {
            if (Allies.All(ally => !ally.Attributes.IsAlive) ||
                Enemies.All(enemy => !enemy.Attributes.IsAlive))
                EveryoneDied = true;
        }

        public FightInfo Fight()
        {
            FightInfo info = new FightInfo();

            IAttackable? ally = GetNextAlive(_allies);
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
            enemy = GetNextAlive(_enemies);

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

        private FightInfo CheckIfFighterIsNull(IAttackable? attackable, string infoString, FightInfo info)
        {
            if (attackable is null)
                info.Information += $"{infoString}\n";

            return info;
        }

        private IAttackable? GetNextAlive(Queue<IAttackable> fighters)
        {
            if (fighters.Count == 0)
                return null;

            IAttackable? fighter = null;

            for (int i = 0; i < fighters.Count; i++)
            {
                fighter = fighters.Dequeue();

                if (fighter.Attributes.IsAlive)
                    break;
            }

            if (fighter is null || !fighter.Attributes.IsAlive)
                return null;

            fighters.Enqueue(fighter);

            return fighter;
        }

        private IAttackable? GetRandomAlive(IEnumerable<IAttackable> fighters)
        {
            List<IAttackable> aliveFighters = fighters.Where(fighter => fighter.Attributes.IsAlive).ToList();

            if (aliveFighters.Count == 0)
                return null;

            return aliveFighters[_random.Next(aliveFighters.Count)];
        }

        public string GetRandomName()
        {
            if (_names.Count() == 0)
                return "Name";

            return _names[_random.Next(_names.Count())];
        }

        public void SaveToFile(Stream stream)
        {
            string serialized = JsonSerializer.Serialize(this, typeof(Battlefield), new JsonSerializerOptions
            {
                WriteIndented = false
            });

            using(StreamWriter writer = new StreamWriter(stream))
            {
                writer.Write(serialized);
            }
        }

        public void LoadFromFile(Stream stream)
        {
            string rawJson;

            using (StreamReader reader = new StreamReader(stream))
            {
                rawJson = reader.ReadToEnd();
            }

            Battlefield? temp = JsonSerializer.Deserialize<Battlefield>(rawJson, new JsonSerializerOptions
            {
                WriteIndented = false
            });

            if (temp is null)
                return;

            Allies = new List<Human>(temp.Allies);
            Enemies = new List<Human>(temp.Enemies);
        }
    }
}

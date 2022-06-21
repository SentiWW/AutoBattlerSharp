using AutoBattlerSharp.Logic.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using AutoBattlerSharp.Logic.Models.Creatures;
using AutoBattlerSharp.Logic.Models.Items.Weapons;
using AutoBattlerSharp.Logic.Models.Items.Armours;

namespace AutoBattlerSharp.Logic
{
    public class Battlefield
    {
        private Random _random = new Random();
        private string[] _names;

        private int _alliesI = 0;
        private int _enemiesI = 0;
        private bool _allyTurn;

        [JsonPropertyName("allies")]
        [JsonInclude]
        public List<Human> Allies;
        [JsonPropertyName("enemies")]
        [JsonInclude]
        public List<Human> Enemies;
        public bool EveryoneDied = false;
        [JsonPropertyName("weapons")]
        [JsonInclude]
        public List<Weapon> Weapons;
        [JsonPropertyName("armours")]
        [JsonInclude]
        public List<Armour> Armours;

        public Battlefield()
        {
            using (StreamReader reader = new StreamReader(@$"{AppDomain.CurrentDomain.BaseDirectory}\names.txt"))
            {
                _names = reader.ReadToEnd().Trim().Replace('\r', ' ').Split("\n");
            }

            Weapons = new();
            Armours = new();

            Allies = new List<Human>();
            PopulateCreatures(Allies, (byte)_random.Next(1, 10));

            Enemies = new List<Human>();
            PopulateCreatures(Enemies, (byte)_random.Next(1, 10));

            _allyTurn = true;
            if (_random.Next(0, 2) == 1)
                _allyTurn = false;
        }

        private void PopulateCreatures(ICollection<Human> creatures, byte howMany = 4)
        {
            Attributes attributes;

            for (int i = 0; i < howMany; i++)
            {
                attributes = new Attributes()
                {
                    IsAlive = true,
                    IsAttackable = true,
                    Melee = (short)_random.Next(10, 50),
                    Range = (short)_random.Next(10, 50),
                    Sturdiness = (short)_random.Next(10, 50),
                    Resistance = (short)_random.Next(10, 50),
                    Agility = (short)_random.Next(10, 50),
                    Intelligence = (short)_random.Next(10, 50),
                    Attacks = (short)_random.Next(1, 3),
                    Health = (short)_random.Next(5, 30),
                    Speed = (short)_random.Next(5, 30),
                    Strength = (short)_random.Next(5, 30),
                    Magic = (short)_random.Next(5, 30)
                };
                attributes.MaxHealth = attributes.Health;

                creatures.Add(new Human($"{_names[_random.Next(_names.Count())]}", $"Human {i}", new Attributes(attributes)));
            }
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

            IAttackable? attacker = null;
            IAttackable? target = null;

            if (_allyTurn)
                attacker = GetNextAlive(Allies);
            else
                attacker = GetNextAlive(Enemies);

            for (int i = 0; i < attacker.Attributes.Attacks; i++)
            {
                if (_allyTurn)
                    target = GetRandomAlive(Enemies);
                else
                    target = GetRandomAlive(Allies);

                if (attacker is null || target is null)
                    return info;

                info.Attacker = (Human)attacker;
                info.Weapon = ((Human)attacker).Weapon;
                info.Defender = (Human)target;
                info.Armour = ((Human)target).Armour;

                attacker.Attack(target, info);
            }

            _allyTurn = _allyTurn ? false : true;
            return info;
        }

        private IAttackable? GetNextAlive(IEnumerable<IAttackable> fighters)
        {
            IAttackable? fighter = null;

            if (_allyTurn)
            {
                fighter = fighters.Skip(_alliesI++).Where(fighter => fighter.Attributes.IsAlive).FirstOrDefault();

                if (fighter is null)
                {
                    _alliesI = 0;
                    fighter = fighters.Skip(_alliesI++).Where(fighter => fighter.Attributes.IsAlive).FirstOrDefault();
                }

                _alliesI %= fighters.Count();

                return fighter;
            }

            fighter = fighters.Skip(_enemiesI++).Where(fighter => fighter.Attributes.IsAlive).FirstOrDefault();

            if (fighter is null)
            {
                _enemiesI = 0;
                fighter = fighters.Skip(_enemiesI++).Where(fighter => fighter.Attributes.IsAlive).FirstOrDefault();
            }

            _enemiesI %= fighters.Count();

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

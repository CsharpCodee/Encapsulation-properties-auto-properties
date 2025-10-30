using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic11._4
{
    class Player
    {
        private int level;
        private int health;

        public int Level
        {
            get { return level; }
            set
            {
                if (level >= 1 && level <= 100) 
                { level = value; }
                else { Console.WriteLine("Уровень должен быть от 1 до 100!");
                    level = 1;
                }
            }
        }
        public int Health
        {
            get { return health; }
            set
            {
                if (level >= 0 && health <= 100) 
                { health = value; }
                else { Console.WriteLine("Здоровье должно быть от 0 до 100!");
                    health = 0;
                }
            }
        }
        public string Name {get; init;}
        public bool IsAlive => Health > 0;
        public Player(string name, int level, int health)
        {
            Level = level;
            Health = health;
            Name = name;
        }
        public void TakeDamage(int damage)
        {
            Health -= damage; 
            if (Health < 0)
            {
                Health = 0; 
            }
            Console.WriteLine($"Игрок: {Name}, уровень: {Level}, здоровье: {Health}, жив: {(IsAlive ? "да" : "нет")}");

        }
        static void Main(string[] args)
        {
            Player player1 = new Player("Alex", 5, 70);
            Console.WriteLine($"Игрок: {player1.Name}, уровень: {player1.Level}, здоровье: {player1.Health}, жив: {(player1.IsAlive ? "да" : "нет")}");
            player1.TakeDamage(30); 
            player1.TakeDamage(10);
            player1.TakeDamage(40); 

            Player player2 = new Player("Bob", 0, 100); 
            Console.WriteLine($"Игрок: {player2.Name}, уровень: {player2.Level}, здоровье: {player2.Health}, жив: {(player2.IsAlive ? "да" : "нет")}");
        }
    }

}

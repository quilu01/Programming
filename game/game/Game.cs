using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    
    class Game
    {
        public static  Hero mainHero;
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать \nВыбери себе героя");

            for (int i = 0; i < 5; i++)
            {
                Hero hero = new Hero();
                Console.WriteLine($"Здоровье: {hero.Health}\nУрон: {hero.Damage}\nСпособность: {hero.Ability}\nОписание: {hero.Description}");
                if (Interactions.YNInteraction("Выбрать? Y/N")) { mainHero = hero; break; }
                if (i == 4) { Console.WriteLine("Слишком много попыток"); mainHero = hero; }

            }
            Console.Write("Введи имя:");
            mainHero.Name = Console.ReadLine();

        }

    }
    public class Enemy
    {
        string[] names = new string[] { "bobby", "negro", "svin", "cobacho", "uriella", "samuel" };
        Random rnd = new Random();
        private double _health;
        private string _name;
        private int _damage;

        public double Health { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        
        public Enemy(int heroLevel)
        {
            double temp = rnd.Next(75, 125) / 100;
            Health = (10 + 5 * heroLevel) * temp;
            Damage = (int)((1 + heroLevel) * temp);
            Name = names[rnd.Next(names.Length)];
        }
    }
    public class Interactions
    {
        public static Hero Fight(Hero hero, Enemy enemy)
        {

        }
    }
}

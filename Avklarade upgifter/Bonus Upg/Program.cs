using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bonus_
{
    class game
    {
    }
    internal class Program
    {
        int level = 1;
        int experience = 0;
        int health = 100;
        int gold = 0;
        string weapon = "Rusty Sword";

        string mobName;
        string mobPrefix;
        int mobHP;
        int mobMaxDamage;
        int mobMinDamage;
        string mobRarity;

        private static readonly Random rand = new Random();

        static void Main(string[] args)
        {
            bool isPlaying = true;
            Console.WriteLine("As your father returns from his travels, he hands you a mysterious map."); Console.ReadKey();
            Console.WriteLine("The map is old and worn, with strange symbols and markings that you can't decipher."); Console.ReadKey();
            Console.WriteLine("You need to follow this map your father tells you"); Console.ReadKey();
            Console.WriteLine("For I will die soon and this problem won't solve itself."); Console.ReadKey();
            Console.WriteLine("You must go to the dungeon of doom and retrieve the lost treasure."); Console.ReadKey();
            Console.WriteLine("These are the last words of your father"); Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You set out on your journey, following the map through dense forests and treacherous mountains."); Console.ReadKey();
            Console.WriteLine("After days of travel, you finally arrive at the entrance to the dungeon of doom."); Console.ReadKey();
            Console.WriteLine("As you enter the dungeon, you are greeted by a cloaked man.");
            Console.WriteLine("Tell me your name traveller: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}, to the dungeon of doom!"); Console.ReadKey();
            Console.WriteLine("The mysterious man hands you a torch and a rusty sword before disappearing into the shadows."); Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You find yourself standing in the darkness with naught but the torchlight to guide you."); Console.ReadKey();
            Console.WriteLine("You also notice a merchant's cart to your left, filled with various supplies and weapons."); Console.ReadKey();
            Console.WriteLine("You must now chose your path wisely, for danger lurks around every corner."); Console.ReadKey();
            Console.WriteLine("As you go deeper into the dungeon you are met with a choice of 3 doors"); Console.ReadKey();
            Console.WriteLine("What door do you choose? (1, 2, or 3)");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose door " + choice); Console.ReadKey();
            Console.WriteLine("You proceed through the door..."); Console.ReadKey();
            Console.WriteLine("You are met with a small goblin!"); Console.ReadKey();
            Console.WriteLine("Prepare for combat!"); Console.ReadKey();

            while (isPlaying)
            {

            }
        }
        void combat()
        {

        }
        void loot()
        {

        }
        void inventory()
        {

        }
        void stats()
        {

        }
        void flee()
        {

        }
        void shop()
        {

        }
        void levelUp()
        {

        }        
        void mobGenerator()
        {
            string[] mobNames = new string[] { "Goblin", "Troll", "Orc", "Skeleton", "Zombie" };
            int roll = rand.Next(1, 101);
            if (roll <= 50)
            {
                mobRarity = "Common";
            }
            else if (roll <= 80)
            {
                mobRarity = "Uncommon";
            }
            else if (roll <= 95)
            {
                mobRarity = "Rare";
            }
            else
            {
                mobRarity = "Legendary";
            }
            mobName = mobNames[rand.Next(mobNames.Length)];
            if (mobName == "Goblin")
            {
                mobHP = 30;
                mobMinDamage = 5;
            }
            else if (mobName == "Troll")
            {
                mobHP = 50;
                mobMinDamage = 10;
            }
            else if (mobName == "Orc")
            {
                mobHP = 70;
                mobMinDamage = 15;
            }
            else if (mobName == "Skeleton")
            {
                mobHP = 40;
                mobMinDamage = 7;
            }
            else if (mobName == "Zombie")
            {
                mobHP = 60;
                mobMinDamage = 12;
            }
            switch (mobRarity)
            {
                case "Uncommon":
                    mobHP = (int)(mobHP * 1.15);
                    mobMinDamage = (int)(mobMinDamage * 1.15);
                    mobMaxDamage = (int)(mobMaxDamage * 1.15);
                    break;
                case "Rare":
                    mobHP = (int)(mobHP * 1.3);
                    mobMinDamage = (int)(mobMinDamage * 1.3);
                    mobMaxDamage = (int)(mobMaxDamage * 1.3);

                    break;
                case "Epic":
                    mobHP = (int)(mobHP * 1.5);
                    mobMinDamage = (int)(mobMinDamage * 1.5);
                    mobMaxDamage = (int)(mobMaxDamage * 1.5);
                    break;
                case "Legendary":
                    mobHP = (int)(mobHP * 2);
                    mobMinDamage = (int)(mobMinDamage * 2);
                    mobMaxDamage = (int)(mobMaxDamage * 2);
                    break;
            }                                     
        }
    }
}

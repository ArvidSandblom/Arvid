using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string pName;
            string pClass;
            int pHP;
            int pMP;
            bool classError = false;            
            string armour;
            string weapon;
            string staff;       
            

            float gold = 5;

            WriteLine("After losing your father to a fever you have been wandering the wastes of the east for weeks");
            WriteLine("You find yourself alone with naught but your sword and a will to live");
            WriteLine("As you walk along a dusty road, you see a figure in the distance standing in front of a set of large imposing doors");
            WriteLine("Welcome adventurer!\nPlease do tell me your name: ");
            pName = Console.ReadLine();
            WriteLine($"{pName}...", 100); Thread.Sleep(3500);
            WriteLine("What an excellent name for an adventurer");
            WriteLine("Almost as if he can read your mind the cloaked figure begins to talk");
            WriteLine("Behind these doors lie your destiny, he says refusing to elaborate further");
            WriteLine("I see great potential in you, but first you must choose your path");
            Console.ReadLine();
            Console.Clear();
            WriteLine("Whilst listening to the old man he describes how this dungeon may unlock gifts, talents and abilities to its challengers");
            WriteLine("However, he warns that the dungeon is filled with many dangers and that only the strongest will survive");
            WriteLine("Choose wisely adventurer, for your choice will shape your destiny");
            WriteLine("Choose your class:\n1. Warrior\n2. Mage\n3. Rogue");

            WriteLine("Enter the number corresponding to your choice: ");
            pClass = Console.ReadLine();
            Console.Clear();
            while (!classError)
            {
                switch (pClass)
                {
                    case "1":
                        pClass = "Warrior";
                        pHP = 150;
                        pMP = 50;
                         
                        classError = false;
                        break;
                    case "2":
                        pClass = "Mage";
                        pHP = 100;
                        pMP = 150;

                        classError = false;
                        break;
                    case "3":
                        pClass = "Rogue";
                        pHP = 120;
                        pMP = 80;
                        classError = false;
                        break;
                    default:                        
                        WriteLine("YOU FOOL! THAT IS NOT A VALID CLASS!");
                        if (classError) { WriteLine("Alright, piss off"); break; }
                        else { WriteLine("I will give you the choice to choose again and this time, do it wisely"); }
                        classError = true;
                        continue;
                }
            }
            classError = false;
            WriteLine($"Now that is an excellent class.\nI believe {pClass} will suit you quite well");
            WriteLine("He begins opening the doors and you are greeted by a huge stone chamber with ancient statues of soldiers lining the walls");
            WriteLine("At the end of the hall you are met with three doors of different colours");
            WriteLine("As you gaze upon the doors you remember something the old man told you: 'When it comes to the doors, common knowledge as to difficulty applies'");
            WriteLine("Now you must choose one of the doors: 1.Red, 2.Black or 3.Yellow");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    WriteLine("As you open the red door");
                    int roll = rnd.Next(1,10);
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:    
                    break;

            }
        }
        static void WriteLine(string text, int sleepMs = 35)
        {
            bool skip = false;
            const int chunk = 10; // poll interval in ms for key press
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);

                if (skip)
                {
                    // If skipping, write remainder immediately and break.
                    if (i < text.Length - 1)
                        Console.Write(text.Substring(i + 1));
                    break;
                }

                int waited = 0;
                while (waited < sleepMs)
                {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Enter)
                        {
                            skip = true;
                            // write the rest of the text instantly
                            if (i < text.Length - 1)
                                Console.Write(text.Substring(i + 1));
                            break;
                        }
                        // If other keys were pressed, ignore them and continue polling.
                    }

                    int toSleep = Math.Min(chunk, sleepMs - waited);
                    Thread.Sleep(toSleep);
                    waited += toSleep;

                    if (skip) break;
                }

                if (skip) break;
            }

            Console.Write("\n");
        }
        void newRoom(string roomType)
        {
            
            Random rnd = new Random();
            int roll = rnd.Next(1, 11);
            switch (roomType)
            {
                case "Green":
                    switch (roll)
                    {
                        case 0:
                            
                            break;
                    }
                    break;
                case "Yellow":
                    break;
                case "Red":
                    break;
                case "Black":
                    break;                
                    
            }
        }
        void birthNewEnemy()
        {
            int health;
            string name;
            int level;
        }
        void castSpell(string spellName)
        {

        }
        void attack(string attackType)
        {

        }
        void useItem(string itemName)
        {

        }
        void shop()
        {

        }
        void showInventory()
        {
                        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Upg._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string playerName = "";
            int playerHP = 100;
            int weaponChoice;
            bool weaponError = false;
            int pMaxDamage = 0;
            int pMinDamage = 0;
            int pDamage = 0;
            int pHitChance = 0;
            int mobHP = 100;
            int mobMaxDamage;
            int mobMinDamage;
            int mobDamage = 0;
            int mobHitType = 0;
            int mobHitChance = 0;
            int hitType;
            string mob = "Goblin";
            int mobHitRoll = 0;            
            // Introduction

            Console.WriteLine("Välkommen till denna stridssimulator!");
            Console.ReadKey();
            Console.WriteLine("Vad heter din karaktär?");
            playerName = Console.ReadLine();
            Console.WriteLine("Välkommen " + playerName + ", till denna textbaserade simulatorspel");
            Console.ReadKey();
            Console.WriteLine("Reglerna är följande: ");
            Console.ReadKey();
            Console.WriteLine("Du och din motståndare kommer slå varandra tills någon av er når 0 HP");
            Console.ReadKey();
            Console.WriteLine("OBS! Alla val i spelet kommer göras med siffrorna 1-9 beroende på hur många val det finns att göra");
            Console.ReadKey();
            Console.WriteLine("Du kommer få välja mellan tre vapen som har olika mängd skada och olik chans att träffa. ");
            Console.ReadKey();
            Console.WriteLine("Du kommer få välja nytt vapen att slå med innan varje slag ");
            Console.ReadKey();
            Console.WriteLine("Dessa vapen har tre olika slag: Lätt, Mellan och Hårt.");
            Console.ReadKey();
            Console.WriteLine("Lätta slag är lättare att träffa men gör mindre skada.");
            Console.ReadKey();
            Console.WriteLine("Mellan slag gör mer skada men är svårare att träffa.");
            Console.ReadKey();            
            Console.WriteLine("Hårda slag är svårast att träffa men gör mest skada");
            Console.ReadKey();
            Console.WriteLine("Din motståndare kommer välja mellan lätt, mellan eller hårt slag");
            Console.ReadKey();
            Console.WriteLine("Din motståndare har en kniv med följande slag:");
            Console.WriteLine("Lätt slag: 1-10 skada, 90% chans att träffa\nMellan slag: 5-15 skada, 70% chans att träffa\nHårt slag: 10-20 skada, 50% chans att träffa:");
            Console.ReadKey();
            Console.WriteLine("Du har tre vapnen med olika sannoliketer att träffa de olika slagen\nNu får du välja:");
            Console.ReadKey();
            Console.WriteLine("Svärd:\nLätt slag: 1-10 skada, 80% att träffa\nMellan slag: 5-15 skada, 60% chans att träffa\nHårt slag: 10-30 skada med 40% att träffa");
            Console.ReadKey();
            Console.WriteLine("Yxa:\nLätt slag: 5-10 skada, 70% att träffa\nMellan slag: 5-20 skada, 50% chans att träffa\nHårt slag: 20-50 skada med 20% att träffa");
            Console.ReadKey();
            Console.WriteLine("Spjut:\nLätt slag: 1-10 skada, 90% att träffa\nMellan slag: 10-20 skada, 40% chans att träffa\nHårt slag: 20-40 skada med 30% att träffa");
            Console.ReadKey();

            // Start fight

            while (playerHP > 0 && mobHP > 0)
            {
                // Player attack
                Console.ReadKey();
                Console.Clear();
                if (weaponError == false) { Console.WriteLine(playerName + " har " + playerHP + "HP" + "\n" + mob + " har " + mobHP + "HP"); }
                weaponError = false;
                Console.WriteLine("Välj ditt vapen:\n1. Svärd\n2. Yxa\n3. Spjut");
                weaponChoice = int.Parse(Console.ReadLine());
                Console.WriteLine("1. Lätt slag\n2. Mellan Slag\n3. Hårt slag");
                hitType = int.Parse(Console.ReadLine());

                // Weapon and hit type choice
                // Sword
                if (weaponChoice == 1)
                {
                    switch (hitType)
                    {
                        case 1:
                            pMinDamage = 1;
                            pMaxDamage = 10;
                            pHitChance = 80;
                            pDamage = rnd.Next(pMinDamage, pMaxDamage + 1);
                            break;
                        case 2:
                            pMinDamage = 5;
                            pMaxDamage = 15;
                            pHitChance = 60;
                            pDamage = rnd.Next(pMinDamage, pMaxDamage + 1);
                            break;
                        case 3:
                            pMinDamage = 10;
                            pMaxDamage = 30;
                            pHitChance = 40;
                            pDamage = rnd.Next(pMinDamage, pMaxDamage + 1);
                            break;
                        default:
                            Console.WriteLine("Ogiltigt val, försök igen.");
                            weaponError = true;
                            continue;

                    }
                }
                // Axe
                else if (weaponChoice == 2)
                {
                    switch (hitType)
                    {
                        case 1:
                            pMinDamage = 5;
                            pMaxDamage = 10;
                            pHitChance = 70;
                            pDamage = rnd.Next(pMinDamage, pMaxDamage + 1);
                            break;
                        case 2:
                            pMinDamage = 5;
                            pMaxDamage = 20;
                            pHitChance = 50;
                            pDamage = rnd.Next(pMinDamage, pMaxDamage + 1);
                            break;
                        case 3:
                            pMinDamage = 20;
                            pMaxDamage = 50;
                            pHitChance = 20;
                            pDamage = rnd.Next(pMinDamage, pMaxDamage + 1);
                            break;
                        default:
                            Console.WriteLine("Ogiltigt val, försök igen.");
                            weaponError = true;
                            continue;
                    }
                }
                // Spear
                else if (weaponChoice == 3)
                {
                    switch (hitType)
                    {
                        case 1:
                            pMinDamage = 1;
                            pMaxDamage = 10;
                            pHitChance = 90;
                            pDamage = rnd.Next(pMinDamage, pMaxDamage + 1);
                            break;
                        case 2:
                            pMinDamage = 10;
                            pMaxDamage = 20;
                            pHitChance = 40;
                            pDamage = rnd.Next(pMinDamage, pMaxDamage + 1);
                            break;
                        case 3:
                            pMinDamage = 20;
                            pMaxDamage = 40;
                            pHitChance = 30;
                            pDamage = rnd.Next(pMinDamage, pMaxDamage + 1);
                            break;
                        default:
                            Console.WriteLine("Ogiltigt val, försök igen.");
                            weaponError = true;
                            continue;
                    }
                }
                //Weapon choice error
                else
                {
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    weaponError = true;
                    continue;
                }
                // Player attack roll
                int hitRoll = rnd.Next(1, 101);
                Console.WriteLine("Du rullade " + hitRoll);
                if (hitRoll <= pHitChance)
                {
                    mobHP -= pDamage;
                    Console.WriteLine("Du träffade " + mob + " med " + pDamage + " skada!");
                }
                else
                {
                    Console.WriteLine("Du missade ditt slag!");
                }


                // Mob hit type

                mobHitType = rnd.Next(1, 4);
                switch (mobHitType)
                {
                    case 1:
                        mobMinDamage = 1;
                        mobMaxDamage = 10;
                        mobHitChance = 90;
                        mobDamage = rnd.Next(mobMinDamage, mobMaxDamage + 1);
                        break;
                    case 2:
                        mobMinDamage = 5;
                        mobMaxDamage = 15;
                        mobHitChance = 70;
                        mobDamage = rnd.Next(mobMinDamage, mobMaxDamage + 1);
                        break;
                    case 3:
                        mobMinDamage = 10;
                        mobMaxDamage = 20;
                        mobHitChance = 50;
                        mobDamage = rnd.Next(mobMinDamage, mobMaxDamage + 1);
                        break;
                }

                //Mob attack roll
                Console.Clear();
                Console.WriteLine(mob + " försöker slå dig!");
                mobHitRoll = rnd.Next(1, 101);
                switch (mobHitType)
                {
                    case 1:
                        Console.WriteLine(mob + " försöker med ett lätt slag! (90%)");
                        break;
                    case 2:
                        Console.WriteLine(mob + " försöker med ett mellan slag! (70%)");
                        break;
                    case 3:
                        Console.WriteLine(mob + " försöker med ett hårt slag! (50%)");
                        break;
                }
                Console.WriteLine(mob + " rullade " + mobHitRoll);
                if (mobHitRoll <= mobHitChance)
                {
                    playerHP -= mobDamage;
                    Console.WriteLine(mob + " träffade dig med " + mobDamage + " skada!");
                }
                else
                {
                    Console.WriteLine(mob + " missade sitt slag!");

                }



            }
            // End fight
            Console.Clear();
            if (playerHP <= 0)
            {
                Console.WriteLine("Du har förlorat mot " + mob + "!");
            }
            else if (mobHP <= 0)
            {
                Console.WriteLine("Du har besegrat " + mob + "! Grattis!");
            }
        }
    }
}

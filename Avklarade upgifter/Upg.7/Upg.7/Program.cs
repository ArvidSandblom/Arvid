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
            string weaponType = "";
            int weaponChoice;
            int pMaxDamage;
            int pMinDamage;
            int pDamage;
            int mobHP = 100;
            int mobMaxDamage;
            int mobMinDamage;
            int mobDamage;
            string mobType = "Goblin";

            Console.WriteLine("Välkommen till denna stridssimulator!");
            Console.ReadKey();
            Console.WriteLine("Vad heter din karaktär?");
            playerName = Console.ReadLine();
            Console.WriteLine("Välkommen " + playerName + " till detta textbaserade simulatorspeletL");
            Console.ReadKey();
            Console.WriteLine("Reglerna är följande: ");
            Console.ReadKey();
            Console.WriteLine("Du och din motståndare kommer slå varandra tills någon av er når 0 HP");
            Console.ReadKey();
            Console.WriteLine("Du kommer få välja mellan tre vapen som har olika mängd skada. ");
            Console.ReadKey();
            Console.WriteLine("Du kommer få välja nytt vapen att slå med innan varje slag ");
            Console.ReadKey();
            Console.WriteLine("Dessa vapen har tre olika slag: Lätt, Mellan och Hårt.Mellan slag gör mer skada men är svårare att träffa.");
            Console.ReadKey();
            Console.WriteLine("Lätta slag är lättare att träffa men gör mindre skada.");
            Console.ReadKey();
            Console.WriteLine("Hårda slag är svårast att träffa men gör mest skada");
            Console.ReadKey();
            Console.WriteLine("De tre vapnen har olika sannoliketer att träffa de olika slagen");
            Console.ReadKey();
            Console.WriteLine("Svärd:\nLätt slag: 1-10 skada, 80% att träffa\nMellan slag: 5-15 skada, 60% chans att träffa\nHårt slag: 10-30 skada med 40% att träffa");
            Console.ReadKey();
            Console.WriteLine("Yxa:\nLätt slag: 5-10 skada, 70% att träffa\nMellan slag: 5-20 skada, 50% chans att träffa\nHårt slag: 15-35 skada med 30% att träffa");
            Console.ReadKey();
            Console.WriteLine("Spjut:\nLätt slag: 1-10 skada, 90% att träffa\nMellan slag: 10-20 skada, 40% chans att träffa\nHårt slag: 20-40 skada med 25% att träffa");
            Console.ReadKey();
            while (playerHP > 0 && mobHP > 0)
            {
                Console.WriteLine(playerName + " har " + playerHP + "\n" + mobType + " har " + mobHP);
                Console.WriteLine("Välj ditt vapen:\n1. Svärd\n2. Yxa\n3. Spjut");

            }
            

        }
    }
}

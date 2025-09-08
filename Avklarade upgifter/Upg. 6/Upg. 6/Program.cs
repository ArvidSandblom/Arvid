using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upg._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Upgift 6.
            int pengar = 100;
            List<string> glassar = new List<string>();

            while (pengar > 0)
            {
                Console.WriteLine("Du har " + pengar + "kr" + "\nVill du köpa en glass? [Y/N]");
                char svar = Console.ReadKey(true).KeyChar;
                if (char.ToLower(svar) == 'y')
                {
                    Console.WriteLine("Vill du ha en stor glass, mellan eller liten glass? \nStor glass = 50kr \nMellan glass = 25kr \nLiten glass = 10kr");
                    string val = Console.ReadLine();
                    switch (val.ToLower())
                    {
                        case "stor":
                            pengar -= 50;
                            glassar.Add("Stor glass");
                            break;
                        case "mellan":
                            pengar -= 25;
                            glassar.Add("Mellan glass");
                            break;
                        case "liten":
                            pengar -= 10;
                            glassar.Add("Liten glass");
                            break;
                        default:
                            Console.WriteLine("Du måste välja stor, mellan eller liten.");
                            break;
                    }
                    if (val.ToLower() == "stor" || val.ToLower() == "mellan" || val.ToLower() == "liten")
                    {
                        Console.WriteLine("Du har köpt:");
                        foreach (var glass in glassar)
                        {
                            Console.WriteLine("- " + glass);
                        }
                    }

                }
                else if (char.ToLower(svar) == 'n')
                {
                    Console.WriteLine("Okej, ha en bra dag!");
                    break;
                }
                else
                {
                    Console.WriteLine("Du måste svara med Y eller N.");
                }
            }
        }
    }
}

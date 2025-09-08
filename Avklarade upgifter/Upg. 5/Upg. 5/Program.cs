using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upg._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldo = 500;

            while (saldo > 0) {
                Console.WriteLine("Du har " + saldo + " kronor på kontot");
                Console.WriteLine("Vill du ta ut pengar pengar från ditt konto? [Y/N]");
                string val = Console.ReadLine();
                if (val.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Hur mycket vill du ta ut?");
                    int uttag = int.Parse(Console.ReadLine());
                    Console.WriteLine("Du tar ut " + uttag + " kronor");
                    saldo -= uttag;

                }

                else if (val.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Du har valt att stänga bankomaten, stämmer det? [Y/N]");
                    string stäng = Console.ReadLine();
                    if (stäng.Equals("Y", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Du har valt att stänga bankomaten, välkommen åter!");
                        break;
                    }
                    else if (stäng.Equals("N", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Du har valt att inte stänga bankomaten, välkommen tillbaka!");
                    }
                    else
                    {
                        Console.WriteLine("Felaktigt val, försök igen.");
                    }
                }
                else
                {
                    Console.WriteLine("Felaktigt val, försök igen.");

                }
            }
        }
    }
}

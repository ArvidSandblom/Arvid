using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upg._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[4];
            Console.WriteLine("Namge tre namn: ");
            Console.Write("Namn 1: ");
            namn[0] = Console.ReadLine();
            Console.Write("Namn 2: ");
            namn[1] = Console.ReadLine();
            Console.Write("Namn 3: ");
            namn[2] = Console.ReadLine();
            bool sats = true;
            while (sats)
            {
                Console.WriteLine("Sök efter ett namn: (Använd 0 för en komplett lista)");
                int choice = int.Parse(Console.ReadLine());                
                if (choice > 0 && choice < 4)
                {
                    Console.WriteLine("Du sökte efter: " + namn[choice-1]);
                }
                else if (choice == 0)
                {
                    Console.WriteLine("Du får alla namn: ");
                    for (int i = 0; i <= 3; i++)
                    {
                        Console.WriteLine(namn[i]);
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upg._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vad heter du? ");
            string namn = Console.ReadLine();
            Console.WriteLine("Vilket år är du född? ");
            int år = int.Parse(Console.ReadLine());

            int totAge = DateTime.Now.Year - år;
            Console.WriteLine("Hej " + namn + ", du är antingen " + totAge + " eller " + (totAge - 1) + " år gammal.");

            if (DateTime.Now.Year - år < 20)
            {
                Console.WriteLine("Du är ett barn");
            }
            else if (DateTime.Now.Year - år > 20 && DateTime.Now.Year - år < 30)
            {
                Console.WriteLine("Du är en ung vuxen");
            }
            else if (DateTime.Now.Year - år > 30 && DateTime.Now.Year - år < 51)
            {
                Console.WriteLine("Du ligger i medelålder");
            }
            else if (DateTime.Now.Year - år > 50)
            {
                Console.WriteLine("Du är gammal");
            }
            else
            {
                Console.WriteLine("404 Answer not found");
            }
        }
    }
}

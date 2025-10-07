using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upg._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sten, Sax, Påse med $$
            int playerCash = 100;
            int aiCash = 100;
            int bet;
            string playerChoice;
            string aiChoice;
            Console.WriteLine("Välkommen till Sten, Sax, Påse med betting!");

            while (playerCash >= 0 || aiCash >= 0)
            {
                Console.WriteLine("Du har " + playerCash + "kr och AI har " + aiCash + "kr.");


                //Spelare väljer hur mycket den vill betta
                Console.WriteLine("Välj hur mycket du vill betta denna runda: ");
                bet = int.Parse(Console.ReadLine());
                if (bet > playerCash)
                {
                    Console.WriteLine("Du har inte tillräckligt med pengar för att betta så mycket. Försök igen.");
                    continue;
                }

                Console.WriteLine("Välj Sten(1), Sax(2) eller Påse(3): ");
                Console.WriteLine("Välj med siffror 1-3");
                playerChoice = Console.ReadLine();
                Console.Clear();
                switch (playerChoice)
                {
                    case "1":
                        playerChoice = "Sten";
                        break;
                    case "2":
                        playerChoice = "Sax";
                        break;
                    case "3":
                        playerChoice = "Påse";
                        break;
                }
                aiChoice = new Random().Next(1, 4).ToString();
                switch (aiChoice)
                {
                    case "1":
                        aiChoice = "Sten";
                        break;
                    case "2":
                        aiChoice = "Sax";
                        break;
                    case "3":
                        aiChoice = "Påse";
                        break;
                }
                Console.WriteLine("Du valde " + playerChoice + " och AI valde " + aiChoice + ".");
                if (playerChoice == aiChoice)
                {
                    Console.WriteLine("Oavgjort! Ingen vinner denna runda.");
                }
                else if ((playerChoice == "Sten" && aiChoice == "Sax") || (playerChoice == "Sax" && aiChoice == "Påse") || (playerChoice == "Påse" && aiChoice == "Sten"))
                {
                    playerCash += bet;
                    aiCash -= bet;
                    Console.WriteLine("Du vann denna runda med " + playerChoice + " mot " + aiChoice + " och tjänade " + bet + "kr!");
                }
                else
                {
                    playerCash -= bet;
                    aiCash += bet;
                    Console.WriteLine("AI vann denna runda med " + aiChoice + " mot " + playerChoice + " och du förlorade " + bet + "kr!");
                }
            }         
        }
    }
}

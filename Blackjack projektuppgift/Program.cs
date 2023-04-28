using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Välkommen till 21:an !!");
            Console.WriteLine(" ");
            
            

            string meny = "0";

            string previouswinner = "Huset";

            while (meny!="4")
            {
                Console.WriteLine(" ");
                Console.WriteLine("välj ett av alternativen:");
                Console.WriteLine(" ");

                Console.WriteLine("1. spela 21an ");
                Console.WriteLine("2. regler för 21an ");
                Console.WriteLine("3. senaste vinnare ");
                Console.WriteLine("4. avsluta program ");
                Console.WriteLine(" ");

                meny = Console.ReadLine();

                switch (meny)
                {
                    case "1":
                        Console.WriteLine("\n working game lol\n");
                        // spelare får se sin poäng och blir frågad om den vill ha ett till kort eller int (j/n)
                        // om ja får spelare nytt kort och får se updaterat poäng och blir frågad om den vill ha ett till kort
                        // om nej så får datorn dra kort tills den har ett poäng högre än spelaren 
                        // om datorn går högre än spelaren men inte över 21 vinner banken
                        // om datorn går över 21 vinner spelaren
                        // efter bank eller spelare vinner får användaren upp startlistan med 4 alternativen 
                        break;
                    case "2":
                        Console.WriteLine(" \ni 21 har alla kort ett värde, ett poäng. du ska försöka komma så nära\n 21 poäng som möjligt utan att gå över genom att dra ett kort i taget.\n Efter att du har dragit dina kort kommer huset att dra kort och\n kommer att fortsättta tills dem har ett högre poäng än dig om \n huset får över 21 vinner du men är huset över dit poäng och under 21 förlorar du.\n");
                        break;
                    case "3":
                        Console.WriteLine(previouswinner+ "\n");
                        break;

                    case "4":
                        Console.WriteLine("\n tack för att du spelade 21 \n");
                        break;

                    default:
                        Console.WriteLine("\n Du har valt ett tal annat än 1, 2, 3 och 4. Försök igen\n");
                        break;
                }
            }
        }
    }
}

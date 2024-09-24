using System.Collections.Concurrent;

namespace Tärningspel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du spela? (ja/nej)");
            string answerPlay = Console.ReadLine();

            while (answerPlay != "nej")
            {
                Random rand = new Random();
                int randomCard = rand.Next(1, 14);
                
                int sumPlayer = 0;
                int sumDealer = 0;

                Console.WriteLine("Välkommen till spelet 21. Få närmast 21 poäng utan att vara över 21 för att vinna.");

                Console.WriteLine("Vill du dra ett kort eller stanna?");
                string answer = Console.ReadLine();

                while (answer != "stanna")
                {
                   
                    if (randomCard >= 11 && randomCard <= 13)
                    {
                        sumPlayer += 10;
                        
                    } 
                    else
                    {
                        sumPlayer += randomCard;
                        
                    }
                    
                    Console.WriteLine("Du drog: " + randomCard + " Din poäng: " + sumPlayer);
                    randomCard = rand.Next(1, 14);

                    if (sumDealer >= 17)
                    {
                        Console.WriteLine("Dealer har stannat. " + "Dealers poäng: " + sumDealer);

                    }
                    else
                    {
                        if (randomCard >= 11 && randomCard <= 13)
                        {
                            sumDealer += 10;

                        }
                        else
                        {
                            sumDealer += randomCard;

                        }
                        
                        Console.WriteLine("Dealer drog: " + randomCard + " Dealers poäng: " + sumDealer);
                        randomCard = rand.Next(1, 14);
                    }

                    if (sumPlayer >= 21 || sumDealer >= 21)
                    {
                        break;
                    }

                    Console.WriteLine("Vill du dra ett kort eller stanna?");
                    answer = Console.ReadLine();

                }

                if (sumDealer > 21)
                {
                    Console.WriteLine("Du har vunnit!");
                   

                }
                else if (sumPlayer > 21)
                {
                    Console.WriteLine("Du har förlorat!");
                   
                }
                else if (sumPlayer == sumDealer)
                {
                    Console.WriteLine("Du har förlorat!");
                    

                }
                else if (sumPlayer == 21)
                {
                    Console.WriteLine("Du har vunnit!");
                  

                }
                else if (sumDealer == 21)
                {
                    Console.WriteLine("Du har förlorat!");

                }
                else if (sumPlayer < 21 && sumDealer < 21)
                {
                    if (sumPlayer > sumDealer)
                    {
                        Console.WriteLine("Du har vunnit!");
                       

                    }
                    else if (sumPlayer < sumDealer)
                    {
                        Console.WriteLine("Du har förlorat!");
                       
                    }
                }
               
                Console.WriteLine("Vill du spela igen? (ja/nej)");
                answerPlay = Console.ReadLine();

            }
            
        }
    }
}

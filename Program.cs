using System;
using System.Timers;
namespace RNG
{
    class Program
    {

        static void Main(string[] args)
        {


            var rand = new Random();

            Double x = 0;

            string Game = "yes";
            do
            {
                DateTime start = DateTime.Now;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                int tries = 0;
                int y = rand.Next(1, 101);

                do
                {
  
                    do
                    {
                        x = Convert.ToDouble(Console.ReadLine());
                        if (x % 1 != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("INPUT ERROR TRY AGAIN");
                        }
                    } while (x % 1 != 0);
                    Console.ForegroundColor = ConsoleColor.Green;

                    if (y < x)
                    {
                        Console.WriteLine("Meine Zahl ist KLEINER bitte versuchen sie nochmals.");
                        tries++;
                    }
                    else if (y > x)
                    {
                        Console.WriteLine("Meine Zahl ist GRÖSSSER bitte versuchen sie nochmals.");
                        tries++;
                    }
                } while (x != y && x % 1 == 0);

                Console.WriteLine("RICHTIG");
                if (tries < 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Anzahl Versuche: " + tries);
                }
                else if (tries < 8)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Anzahl Versuche: " + tries);
                    Console.WriteLine("wpyiyi");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Anzahl Versuche: " + tries);
                    Console.WriteLine("you are bad lol, go check up on doctor you have 2 yil");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                DateTime finish = DateTime.Now;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Ihre Zeit:");
                Console.WriteLine(finish - start);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wollen sie nochmal spielen(yes)");
                Game = Console.ReadLine();
            } while (Game == "yes");
 
        
        }
    }
}

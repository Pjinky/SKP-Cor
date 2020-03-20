using System;

namespace Spil
{
    class Program
    {
        static Random rnd = new Random();
        static int min = 0;
        static int max = 10;

        static void Main(string[] args)
        {
            bool restart = false;
            bool exit = false;
            do
            {

                do
                {
                    int result = rnd.Next(min, max);
                    int attempts = 3;
                    int guess = 0;
                    Console.Clear();
                    Console.WriteLine("Gæt et tal mellem {0}-{1}", min, max);
                    do
                    {
                        String input = Console.ReadLine();
                        guess = int.Parse(input);
                        if (guess > result)
                            Console.WriteLine("Dit gæt (" + guess + ") er for højt." + attempts);
                        if (guess < result)
                            Console.WriteLine("Dit gæt (" + guess + ") er for lavt." + attempts);
                        attempts--;
                    } while (guess != result | attempts > 0);
                    if(guess == result)
                    {
                        Console.WriteLine("Tillykke, du gættede det rigtige tal {0}", result);
                    }
                    else
                    {
                        Console.WriteLine("Desværre, du har opbrugt alle dine forsøg.");
                    }
                    Console.WriteLine();
                    Console.Write("Tryk en vilkårlig tast for at prøve igen, tryk R for at nulstille alt eller ESC for at lukke ned");
                    ConsoleKey ipt = Console.ReadKey().Key;
                    if (ipt == ConsoleKey.Escape)
                    {
                        restart = true;
                        exit = true;
                    }
                    if(ipt == ConsoleKey.R)
                    {
                        restart = true;
                    }
                } while (!restart);
                restart = false;

            } while (!exit);
        }

/*        private static void UInterface()
        {
            Console.WriteLine("1. Start\n2. Vejledning\n3. Genstart");
            Console.WriteLine("Vælg en af valgmulighederne eller tryk ESC for at gå ud");
        }*/

        private static void VInterface()
        {
            Console.WriteLine("Vejledning:");
            Console.WriteLine();
            Console.Write("");
        }
    }
}
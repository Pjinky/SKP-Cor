using System;

namespace Spil
{
    class Program
    {
        static Random rnd = new Random();
        static int min = 0;
        static int max = 10;
        static int highscore = 0;

        static void Main(string[] args)
        {
            bool restart = false;
            bool exit = false;
            do
            {
                Console.Clear();
                UInterface();
                ConsoleKey choice = Console.ReadKey().Key;
                if (UIntChoice(choice) == 1)
                {

                    int point = 0;
                    do
                    {
                        int result = rnd.Next(min, max);
                        int attempts = 3;
                        int guess;

                        Console.Clear();
                        Console.WriteLine("Gæt et tal mellem {0}-{1}", min, max);
                        do
                        {
                            String input = Console.ReadLine();
                            guess = int.Parse(input);
                            if (guess > result)
                                Console.WriteLine("Dit gæt (" + guess + ") er for højt.");
                            if (guess < result)
                                Console.WriteLine("Dit gæt (" + guess + ") er for lavt.");
                            attempts--;
                        } while (guess != result & attempts > 0);
                        if (guess == result)
                        {
                            point++;
                            Console.WriteLine("Tillykke, du gættede det rigtige tal {0}", result);
                        }
                        else
                        {
                            if (point > highscore)
                            {
                                highscore = point;
                            }
                            point = 0;
                            Console.WriteLine("Desværre, du har opbrugt alle dine forsøg.");

                        }
                        Console.WriteLine();
                        Console.WriteLine("Du har " + point + " point og der er en highscore på " + highscore);
                        Console.Write("Tryk en vilkårlig tast for at prøve igen, tryk R for at nulstille alt eller ESC for at lukke ned");
                        ConsoleKey ipt = Console.ReadKey().Key;
                        if (ipt == ConsoleKey.Escape)
                        {
                            restart = true;
                            exit = true;
                        }
                        if (ipt == ConsoleKey.R)
                        {
                            restart = true;
                            if (point > highscore)
                            {
                                highscore = point;
                            }
                        }
                    } while (!restart);
                    restart = false;
                }else if(UIntChoice(choice) == 2)
                {
                    VInterface();
                    ConsoleKey exitVejl;
                    do
                    {
                        exitVejl = Console.ReadKey().Key;
                    } while (exitVejl != ConsoleKey.Escape);
                }

            } while (!exit);
        }

        private static void UInterface()
        {
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Vejledning");
            Console.WriteLine("\n\n\n\nVælg en af valgmulighederne eller tryk ESC for at gå ud");
        }

        private static int UIntChoice (ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    return 1;
                case ConsoleKey.D2:
                    return 2;
                default:
                    return 1;
            }
        }

        private static void VInterface()
        {
            Console.Clear();
            Console.WriteLine("Vejledning til Gæt et Tal:");
            Console.WriteLine();
            Console.Write("I 'Gæt et Tal' skal du (sjovt nok) gætte dig frem til et tal som spillet har genereret i baggrunden \n\nDu vil løbende få at vide om du gætter for højt eller lavt");
            Console.Write("\n\n\n\n\n Tryk på ESC for at komme tilbage");
        }
    }
}
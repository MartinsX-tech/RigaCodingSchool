using System;

namespace Day2X
{
    class Day2
    {
        static void Task1()
        {
            Console.WriteLine("Ievadi x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x >= 0 && x <= 20 && y >= 30 && y <= 50)
            {
                Console.WriteLine(x + " + " + y + " = " + (x + y));
            }
            else
            {
                Console.WriteLine("x ir jābūt robežās no 0 līdz 20 & y ir jābūt robežās no 30 līdz 50...");
            }
        }
        static void Task2()
        {
            Console.WriteLine("Ievadiet mājas priekšmetu: ");
            string thing = Console.ReadLine();
            string thingfix = thing.Substring(0, 1);
                        
            if (thingfix == "a" || thingfix == "b" || thingfix == "c" || thingfix == "d")
            {
                Console.WriteLine($"priekšmets - {thing} - tiks novietots 1 stāvā!");
            } else if (thingfix == "e" || thingfix == "f" || thingfix == "g" || thingfix == "h")
            {
                Console.WriteLine($"priekšmets - {thing} - tiks novietots 2 stāvā!");
            } else if (thingfix == "i" || thingfix == "j" || thingfix == "k" || thingfix == "l")
            {
                Console.WriteLine($"priekšmets - {thing} - tiks novietots 3 stāvā!");
            } else if (thingfix == "m" || thingfix == "n" || thingfix == "o" || thingfix == "p")
            {
                Console.WriteLine($"priekšmets - {thing} - tiks novietots 4 stāvā!");
            } else if (thingfix == "r" || thingfix == "s" || thingfix == "t" || thingfix == "u")
            {
                Console.WriteLine($"priekšmets - {thing} - tiks novietots 5 stāvā!");
            } else
            {
                Console.WriteLine($"priekšmets - {thing} - tiks novietots pagrabā!");
            }
        }
        static void Task3()
        {
            Console.WriteLine("Ievadiet eglītes augstumu: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet eglītes zaru diametru: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet eglītes tipu (tradicionālā egle vai sudrabegle): ");
            string type = Console.ReadLine();

            string z = "sudrabegle";
            if (type == z)
            {
                Console.WriteLine("Eglīti drīkst novietot tikai kamīnzāle!");
            }
            else if (50 <= x && x < 100 && 100 <= y && y < 150)
            {
                Console.WriteLine("Eglīti drīkst novietot viesistabā 1");
            }
            else if (100 <= x && x < 150 && 150 <= y && y < 200)
            {
                Console.WriteLine("Eglīti drīkst novietot viesistabā 2");
            }
            else if (150 <= x && x <= 300 && 200 <= y && y <= 300)
            {
                Console.WriteLine("Eglīti drīkst novietot kamīnzālē");
            }
            else
            {
                Console.WriteLine("Nav kur novietot eglīti!");
            }
        }
        static void ExtraTask()
        {
            Console.WriteLine("----- Extra Task -----");
            Console.Write("Ievadi pirmā spēlētāja vārdu: ");
            string firstPlayer = Console.ReadLine();
            Console.Write("Ievadi otrā spēlētāja vārdu: ");
            string secondPlayer = Console.ReadLine();

            Console.WriteLine($"3 reizes ievadi spēlētāja '{firstPlayer}' punktus: ");
            int playerOnePts = 0;
            for (int i = 1; i <= 3; i++)
            {
                playerOnePts += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"3 reizes ievadi spēlētāja '{secondPlayer}' punktus: ");
            int playerTwoPts = 0;
            for (int i = 1; i <= 3; i++)
            {
                playerTwoPts += Convert.ToInt32(Console.ReadLine());
            }

            if (playerOnePts != playerTwoPts)
            {
                Console.WriteLine($"Spēlētājs ar visvairāk punktiem: { (playerOnePts > playerTwoPts ? firstPlayer : secondPlayer) }");
            }
            else
            {
                Console.WriteLine("Abiem spēlētājiem ir vienāds punktu skaits!");
            }

            Console.WriteLine("------------------");
        }
        static void Main(string[] args)
        {
            Console.Write("Ievadiet uzdevuma nr.: ");
            int taskNr = Convert.ToInt32(Console.ReadLine());
            switch (taskNr)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    ExtraTask();
                    break;
                default:
                    Console.WriteLine("Such task does not exist!");
                    break;
            }
        }
    }
}

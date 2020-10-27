using System;
using System.Data.SqlTypes;

namespace Day2
{
    class Program
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


        }
        static void Task3()
        {
            Console.WriteLine("Ievadiet eglītes augstumu: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet eglītes zaru diametru: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet eglītes tipu: ");
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
                Console.WriteLine("Izmēri pārsniedz robežas!");
            }
            static void ExtraTask()
            {

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
}

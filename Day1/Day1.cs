using System;

namespace Day1
{
    class Day1
    {
        static void Task1()
        {
            Console.WriteLine("Mārtiņš Atauga");
        }
        static void Task2()
        {
            int x = 2;
            double y = 3.3253;
            bool z;
            z = (4 > 3);
            string i;
            i = "bababa";
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(i);
        }
        static void Task3()
        {
            int x = 10;
            int y = 15;
            int z = x + y;
            Console.WriteLine(z);
        }
        static void Task4()
        {
            Console.WriteLine("Ievadi savu vārdu: ");
            string x = Console.ReadLine();
            Console.WriteLine(x);
        }
        static void Task5()
        {
            Console.WriteLine("Ievadi savu vārdu: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Ievadi savu uzvārdu: ");
            string lastname = Console.ReadLine();
            String firstnamefix = firstname.Substring(0, 1).ToUpper();
            Console.WriteLine(firstnamefix + ". " + lastname);
        }
        static void ExtraTask()
        {
            Console.WriteLine("Ievadi skaitli a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi skaitli b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"A: {a}, B: {b} ");
        }
        static void Main(string[] args)
        {
            /* Console.WriteLine("Ievadi skaitli x: ");
             string userInput = Console.ReadLine();
             int x = Convert.ToInt32(userInput);*/

            Console.Write("Ievadiet uzdevuma nr.: ");
            int taskNr = Convert.ToInt32(Console.ReadLine());
            switch(taskNr)
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
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    ExtraTask();
                    break;
                default:
                    Console.WriteLine("Such task does not exist!");
                    break;
            }

           /* Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            ExtraTask();*/
        }
    }
}

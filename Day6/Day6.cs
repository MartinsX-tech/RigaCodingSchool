using System;

namespace Day6
{
    class Day6
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadiet uzdevuma nr.: ");
            int taskNr = Convert.ToInt32(Console.ReadLine());
            switch (taskNr)
            {
                case 1:
                    Task1.PrintGreeting(3);
                    break;
                case 2:
                    Task2.PrintMyName("Mārtiņš", "Atauga");
                    break;
                case 3:
                    Task3.PrintNameSurname(Task3.GetNameSurname());
                    break;
                case 4:
                    Console.WriteLine("Ievadiet skaitli n:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Faktoriāls no {n} ir { Task4.Factorial(n)} ");
                    break;
                default:
                    Console.WriteLine("Such task does not exist!");
                    break;
            }
        }
    }
}

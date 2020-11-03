using System;
using TicTacToe;

namespace Day7
{
    class Day7
    {
        static void Task4()
        {

        }
        static void Task5()
        {

        }
        static void Task6()
        {

        }
        static void Task7()
        {

        }
        static void Main(string[] args)
        {
            Console.Write("Ievadiet uzdevuma nr.: ");
            int taskNr = Convert.ToInt32(Console.ReadLine());
            switch (taskNr)
            {
                case 1:
                    TicTacToe.Program.Main(new string[0]);
                    break;
                case 2:
                    Console.Write("Ievadiet savu vārdu: ");
                    string name = Console.ReadLine();
                    Console.Write("Ievadiet savu uzvārdu: ");
                    string surname = Console.ReadLine();
                    Console.Write("Ievadiet savu vecumu: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Task2.PrintNameSurname(name);
                    Task2.PrintNameSurname(name, surname);
                    Task2.PrintNameAge(name, age); //age - noklusējuma vērtība ir 99
                    break;
                case 3:
                    Task3.PrintArrayValues(new int[] { 1, 2, 3, 3, 4, 59, 21, 8 });
                    Console.WriteLine("-----");
                    Task3.PrintArrayValues(new string[] { "abc", "def", "ghi" });
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                case 7:
                    Task7();
                    break;
                default:
                    Console.WriteLine("Such task does not exist!");
                    break;
            }
        }
    }
}

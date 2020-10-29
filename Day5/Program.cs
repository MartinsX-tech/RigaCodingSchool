using System;

namespace Day5
{
    class Program
    {
        static void Task1()
        {
            int[] array = { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8 };

        }
        static void Task2()
        {

        }
        static void Task3()
        {

        }
        static void Task4()
        {

        }
        static void Task5()
        {

        }
        static void Task6()
        {

        }
        static void Main(string[] args)
        {
            CConsole.Write("Ievadiet uzdevuma nr.: ");
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
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                default:
                    Console.WriteLine("Such task does not exist!");
                    break;
            }
        }
    }
}

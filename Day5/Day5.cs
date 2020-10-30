using System;
using System.Security.Cryptography.X509Certificates;

namespace Day5
{
    class Day5
    {
        static void Task1()
        {
            int[] array = { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8 };

            int x = 0;
            do
            {
                Console.WriteLine(array[x]);
                x++;
                if (array[x] == 22)
                {
                    break;
                }
            }
            while (x < array.Length);
        }
        static void Task2()
        {
            string[] vardi = { "Ralfs", "Uģis", "Lokko", "Mokko", "Vokko", "Juris", "Mūris", "Rommo", "Jinx", "Rafaels" };
            string[] uzvardi = { "Krusa", "Celmiņš", "Upe", "Žogs", "Bulls", "Krūms", "Vendetta", "Renee", "Ozols", "Liepa" };

            int x = 0;
            do
            {
                Console.WriteLine(vardi[x] + " " + uzvardi[x]);
                x++;
            }
            while (x < 10);
        }
        static void Task3()
        {
            int[] array = { 4, 68, 7, 12, 56, 33, 1, 90, 4 };

            int x = 0;
            do
            {
                if (array[x] > 15)
                {
                    Console.WriteLine(array[x]);
                }
                x++;
            }
            while (x < array.Length);
        }
        static void Task4()
        {
            string[] array = { "jānis", "pēteris", "andris", "sergejs", "antons" };

            int x = 0;
            do
            {
                if (array[x].Contains("a") || array[x].Contains("ā"))
                {
                    Console.WriteLine(array[x]);
                }
                x++;
            }
            while (x < array.Length);
        }
        static void Task5()
        {
            int[] array = { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8, 43, 56 };

            int x = 0;
            do
            {
                if (array[x] >= 0 && array[x] <= 30)
                {
                    Console.WriteLine(array[x]);
                }
                x++;
            }
            while (x < array.Length);

            Console.WriteLine("-----");

            int i = 0;
            do
            {
                if (array[i] >= 31 && array[i] <= 60)
                {
                    Console.WriteLine(array[i]);
                }
                i++;
            }
            while (i < array.Length);

            Console.WriteLine("-----");

            int z = 0;
            do
            {
                if (array[z] >= 61 && array[z] <= 90)
                {
                    Console.WriteLine(array[z]);
                }
                z++;
            }
            while (z < array.Length);
        }
        static void Task6()
        {
            int[,] array2d = new int[5, 5];

            array2d[0, 0] = 1;

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.WriteLine(array2d[i , j]);
                }
            }
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

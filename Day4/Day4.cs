using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Day4
{
    class Day4
    {
        static void Task1()
        {
            string[] array = { "Jānis", "Pēteris", "Andris" };

            int x = 0;
            do
            {
                Console.WriteLine(array[x]);
                x++;
            }
            while (x < array.Length);
        }
        static void Task2()
        {
            int[] array = { 1, 3, 4, 8, 0, 23 };

            int x = 0;
            do
            {
                Console.WriteLine(array[x]);
                x++;
            }
            while (x < array.Length);

            Console.WriteLine("---");

            int i = 0;
            do
            {
                if (array[i] > 5)
                {
                    Console.WriteLine(array[i]);
                }
                i++;
            }
            while (i < array.Length);
        }
        static void Task3()
        {
            string[] array = { "Jānis", "Pēteris", "Andris", "Jansons", "Juris" };

            int x = 0;
            do
            {
                Console.WriteLine(array[x]);
                x++;
            }
            while (x < array.Length);

            Console.WriteLine("---");

            int i = 0;
            do
            {
                string firstnamefix = array[i].Substring(0, 1).ToUpper();

                if (firstnamefix == "J")
                {
                    Console.WriteLine(array[i]);
                }
                i++;
            }
            while (i < array.Length);

        }
        static void Task4()
        {
            int[] array = new int[10];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
            }
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
                    Task4();
                    break;
                case 5:
                    ExtraTask();
                    break;
                default:
                    Console.WriteLine("Such task does not exist!");
                    break;
            }
        }
    }
}

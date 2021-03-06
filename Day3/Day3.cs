﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace Day3
{
    enum Day
    {
        Pirmdiena,
        Otrdiena,
        Trešdiena,
        Ceturtdiena,
        Piektdiena,
        Sestdiena,
        Svētdiena
    }
    class Day3
    {
        static void Task1()
        {
            int[] array = { 1, 6, 7, 78, 9, 9 };
            Console.WriteLine(String.Join(", ", array));
        }
        static void Task2()
        {
            Console.WriteLine("Ievadi TRUE vai FALSE: ");
            bool bl = Convert.ToBoolean(Console.ReadLine());

            if (bl == true)
            {
                Console.WriteLine("Jūsu pusdienas ir gatavas!");
            }
            else
            {
                Console.WriteLine("Jums pusdienas nebūs...");
            }

        }
        static void Task3()
        {
            bool bl = true;
            int x = 0;
            
            while (bl = true && x < 20)
            {
                x++;
                Console.WriteLine(x);
                Console.WriteLine(bl);
            } if (x == 20)
            {
                bl = false;
                Console.WriteLine("---");
                Console.WriteLine(bl);
            }
        }
        static void Task4()
        {
            Console.WriteLine("Ievadi skaitli: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }
        static void Task5()
        {
            int[] array = { 100, 200, 233, 66, 77, 98 };
            Console.WriteLine(String.Join(", ", array[0] + ", " + array[5]));
        }
        static void Task6()
        {
            int[] array = { 7, 4, 7, 3, 6, 9, 2 };
            Console.WriteLine(String.Join(", ", array));

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 3)
                {
                    array[i] = 10;
                }
            }
            Console.WriteLine(String.Join(", ", array));
        }
        static void Task7()
        {
            string[] array = { "Jānis", "Pēteris", "Andris" };
            Console.WriteLine(array[1]);
            array[2] = "Jēkabs";
        }
        static void Task8()
        {
            Day day = Day.Piektdiena;
            Console.WriteLine(day);
        }
        static void ExtraTask()
        {
            Console.Write("Ievadiet skaitli no 0 līdz 20: ");
            int input = Convert.ToInt32(Console.ReadLine());

            while (input > 20 || input < 0)
            {
                Console.WriteLine("Neatļauts skaitlis!");
                input = Convert.ToInt32(Console.ReadLine());
            }
            int i = 1;
            while (i <= input)
            {
                Console.Write(i * input + " ");
                i++;
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
                case 7:
                    Task7();
                    break;
                case 8:
                    Task8();
                    break;
                case 9:
                    ExtraTask();
                    break;
                default:
                    Console.WriteLine("Such task does not exist!");
                    break;
            }
        }
    }
}

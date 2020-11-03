using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Task2
    {
        public static void PrintNameSurname(string name)
        {
            Console.WriteLine($"name: {name}");
        }
        public static void PrintNameSurname(string name, string surname)
        {
            Console.WriteLine($"name: {name}, surname: {surname}");
        }
        public static void PrintNameAge(string name, int age = 99)
        {
            Console.WriteLine($"name: {name}, age: {age}");
        }
    }
}

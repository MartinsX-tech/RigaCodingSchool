using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Task3
    {
        public static void PrintArrayValues(int[] intArray)
        {
            foreach (var item in intArray)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void PrintArrayValues(string[] stringArray)
        {
            foreach (var item in stringArray)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

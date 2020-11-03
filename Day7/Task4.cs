using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day7
{
    class Task4
    {
        /*public static void GetNonEmptyArray(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] != "")
                {
                    Console.WriteLine(stringArray[i]);
                }
            }
        }
        public static void PrintArrayValues(string[] printedArray)
        {
            Array.ForEach(printedArray, Console.WriteLine);
        }*/

        public static string[] GetNonEmptyArray(string[] array)
        {
            //return array.Where(item => !String.IsNullOrEmpty(item)).ToArray();

            List<string> list = new List<string>();
            foreach (string item in array)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    list.Add(item);
                }
            }

            return list.ToArray();
        }
    }
}

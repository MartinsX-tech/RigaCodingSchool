using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Day6
{
    class Task3
    {
        public static string GetNameSurname()
        {
            Console.WriteLine("Ievadi savu vārdu un uzvārdu: ");
            string nameplus = Console.ReadLine();
            return nameplus;
        }
        public static void PrintNameSurname(string nameSurname)
        {
            Console.WriteLine(nameSurname);
        }
    }
}

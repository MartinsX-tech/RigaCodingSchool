using System;

namespace Day8
{
    class Day8
    {
        static void Main(string[] args)
        {
            int[] intArray = { 3, 5, 6, 6, 8, 2 };
            Console.WriteLine(String.Join(",", intArray));
            intArray = Task1.GetOnlySmallValues(intArray);
            Console.WriteLine(String.Join(",", intArray));
            /*Console.WriteLine(String.Join(",", Task1.GetOnlySmallValues(intArray)));*/

            Console.WriteLine(PasswordValidator.ValidatePassword("12345"));
            Console.WriteLine(PasswordValidator.ValidatePassword("12A34"));
            Console.WriteLine(PasswordValidator.ValidatePassword("12AGAFFS34"));
        }
    }
}

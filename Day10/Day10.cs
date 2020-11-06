using System;
using System.Collections.Generic;
using System.Linq;

namespace Day10
{
    class Day10
    {
        static void Main(string[] args)
        {
            Chair chair01 = new Chair(72.50f, 75.20f, 120.00f, "yellow", 300.10f);
            Chair chair02 = new Chair(80.50f, 56.20f, 120.00f, "grey", 199.99f);
            Chair chair03 = new Chair(72.50f, 56.20f, 100.00f, "black", 200.99f);
            Chair chair04 = new Chair(72.50f, 69.20f, 110.00f, "purple", 300.10f);
            Chair chair05 = new Chair(69.50f, 50.20f, 101.00f, "brown", 300.10f);

            var chairList = new List<Chair>();
            chairList.Add(chair01);
            chairList.Add(chair02);
            chairList.Add(chair03);
            chairList.Add(chair04);
            chairList.Add(chair05);

            float maxPrice = chairList.Max(chair => chair.Price);
            List<Chair> mostExpensiveChairs = chairList.Where(chair => chair.Price == maxPrice).ToList();
            //Chair[] MostExpChairsArray = chairList.Where(chair => chair.Price == maxPrice).ToArray();

            foreach (Chair chair in mostExpensiveChairs)
            {
                Console.WriteLine(chair.ToString());
            }
            Console.WriteLine("-----");

            /*List<Chair> ChairWithColorBrown = chairList.Where(chair => chair.Color == "brown").ToList();

            foreach (Chair chair in ChairWithColorBrown)
            {
                Console.WriteLine(chair.ToString());
            }*/

            Chair foundChair = chairList.Where(chair => chair.Color == "purple").FirstOrDefault();
            if (foundChair != null)
            {
                Console.WriteLine(foundChair);
            }
            else
            {
                Console.WriteLine("Krēsls netika atrasts!");
            }
            Console.WriteLine("-----");

            ToDo item1 = new ToDo("Dishes", "Wash the dishes", WeekDayEnum.Friday, false);
            ToDo item2 = new ToDo("Clean house", "Clean the house", WeekDayEnum.Saturday, false);
            ToDo item3 = new ToDo("fdad", "fafa", WeekDayEnum.Thurday, true);
            ToDo item4 = new ToDo("affwfw", "ffwfwfa", WeekDayEnum.Wednesday, false);

            List<ToDo> itemList = new List<ToDo>();
            itemList.Add(item1);
            itemList.Add(item2);
            itemList.Add(item3);
            itemList.Add(item4);

            List<ToDo> undoneItems = itemList.Where(itemList => itemList.Done != true).ToList();
            Console.WriteLine("Undone items:");
            foreach (ToDo item in undoneItems)
            {
                Console.WriteLine(item);
            }

            List<ToDo> fridayItems = itemList.Where(item => item.WeekDay == WeekDayEnum.Friday).ToList();
            Console.WriteLine("Friday items:");
            foreach (ToDo item in fridayItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}

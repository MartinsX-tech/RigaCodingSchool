using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Day9
{
    class Day9
    {
        static void Main(string[] args)
        {
            
            Car BMW = new Car("BMW", "X5", 50000.99f, "yellow", 2016);
            Car Volvo = new Car("Volvo", "A3", 26000.99f, "black", 2011);
            Car Ford = new Car("Ford", "C3", 33960.44f, "red", 2011);
            Car Audi = new Car("Audi", "A6", 1320f, "green", 2011);
            Car Opel = new Car("Opel", "132", 5000f, "blue", 2011);

            List<Car> carList = new List<Car>();
            carList.Add(BMW);
            carList.Add(Volvo);
            carList.Add(Ford);
            carList.Add(Audi);
            carList.Add(Opel);

            float maxPrice = carList.Max(car => car.Price);
            List<Car> mostExpensiveCars = carList.Where(car => car.Price == maxPrice).ToList();
            //Car[] MostExpCarsArray = carList.Where(car => car.Price == maxPrice).ToArray();

            foreach (Car car in mostExpensiveCars)
            {
                Console.WriteLine(car.GetString());
            }

            /*Car expensiveCar = new Car();
            foreach (Car car in carList)
            {
                if (car.Price > expensiveCar.Price)
                {
                    expensiveCar = car;
                }
            }
            Console.WriteLine(expensiveCar.GetString());*/

            /*BMW.make = "BMW";
            BMW.model = "X5";
            BMW.price = 50000.99f;
            BMW.color = "yellow";
            BMW.year = 2016;
            Console.WriteLine(BMW.GetString());*/
        }
    }
}

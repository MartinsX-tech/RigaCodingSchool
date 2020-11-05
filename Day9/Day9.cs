using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Day9
{
    class Day9
    {
        static void Main(string[] args)
        {
            
            Car BMW = new Car("BMW", "X5", 50000.99f, "yellow", 2016);
            Car Volvo = new Car("Volvo", "A3", 26000.99f, "black", 2011);

            List<Car> carList = new List<Car>();
            carList.Add(BMW);
            carList.Add(Volvo);

            Car expensiveCar = new Car();
            foreach (Car car in carList)
            {
                if (car.price > expensiveCar.price)
                {
                    expensiveCar = car;
                }
            }
            Console.WriteLine(expensiveCar.GetString());

            /*BMW.make = "BMW";
            BMW.model = "X5";
            BMW.price = 50000.99f;
            BMW.color = "yellow";
            BMW.year = 2016;
            Console.WriteLine(BMW.GetString());*/
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    class Car
    {
        public string make;
        public string model;
        public float price;
        public string color;
        public int year;

        public Car()
        {

        }
        public Car(string make, string model, float price, string color, int year)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.color = color;
            this.year = year;
        }
        public string GetString()
        {
            return $"{this.make}, {this.model}, {this.price:0.##}, {this.color}, {this.year}";
        }
    }
}

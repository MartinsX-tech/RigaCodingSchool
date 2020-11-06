using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    class Chair
    {
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }

        public Chair()
        {

        }
        public Chair(float length, float width, float height, string color, float price)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.Color = color;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"{this.Length:0.##}, {this.Width:0.##}, {this.Height:0.##}, {this.Color}, {this.Price:0.##}";
        }
    }
}

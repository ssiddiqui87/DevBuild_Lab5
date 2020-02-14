using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class Car
    {
        private int id;
        private string make;
        private string model;
        private int year;
        private double price;

        public int Id { get => id; set => id = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public Car()
        {
            Id = 0;
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;

        }

        public Car(int id, string make, string model, int year, double price)
        {
            this.Id = id;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"ID: {id} {year} {make} {model} -{price.ToString("C")}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class UsedCar : Car
    {
        private double mileage;

        public double Mileage { get => mileage; set => mileage = value; }

        public UsedCar(int id, string make, string model, int year, double price, double mileage) : base(id, make, model, year, price)
        {
            this.mileage = mileage;
        }

        public override string ToString()
        {
            return base.ToString() + $" (Used) - Mileage: {mileage.ToString("0,0")}";
        }
    }
}

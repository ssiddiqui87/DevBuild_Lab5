using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class CarLot
    {
        private List<Car> cars;
        private int id = 1000;

        public CarLot()
        {
            this.cars = new List<Car>();
            this.id = 1000;
        }

        public void AddCar(string make, string model, int year, double price, double mileage)
        {
            
            if (mileage > 0)
            {
                cars.Add(new UsedCar(id, make, model, year, price, mileage));
                id++;
            }
            else
            {
                cars.Add(new Car(id, make, model, year, price));
                id++;
            }
        }

        public void ListCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public void RemoveCar(int id)
        {


            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Id == id)
                {
                    cars.Remove(cars[i]);
                    Console.WriteLine($"Congratulations! You have bought {cars[i]}!");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class CarLot
    {
        private List<Car> cars;
        private int id;

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
            Console.WriteLine("--------------------------------------------------------------------------");
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
                Console.WriteLine("--------------------------------------------------------------------------");
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

        public void SearchCar()
        {
            Console.WriteLine("Do you want to search for \n1. Make" +
                "\n2. Year" +
                "\n3. Cars of an entered price or less");
            Console.Write("Enter choice here (1-3): ");
            int input = int.Parse(Console.ReadLine());

            while (input < 1 || input > 3)
            {
                Console.WriteLine("That is not a valid entry.");
                Console.WriteLine("Do you want to search for \n1. Make" +
             "\n2. Year" +
             "\n3. Cars of an entered price or less");
                Console.Write("Enter choice here (1-3): ");
                input = int.Parse(Console.ReadLine());
            }

            if (input == 1)
            {
                Console.Write("What make do you want to search for? ");
                string make = Console.ReadLine();
                foreach (Car car in cars)
                {
                    if (car.Make.Contains(make))
                    {
                        Console.WriteLine(car);
                    }
                }
            }
            else if (input == 2)
            {
                Console.Write("What year do you want to search for? ");
                int year = int.Parse(Console.ReadLine());
                foreach (Car car in cars)
                {
                    if (car.Year.Equals(year))
                    {
                        Console.WriteLine(car);
                    }

                }
            }
            else if (input == 3)
            {
                Console.Write("What is the max price? ");
                double price = double.Parse(Console.ReadLine());
                foreach (Car car in cars)
                {
                    if (car.Price < price)
                    {
                        Console.WriteLine(car);
                    }
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;

namespace Lab5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Laura and Sameer's car lot!");
            CarLot carlot = new CarLot();
            carlot.AddCar("Ford", "Mustang", 2020, 45000, 0);
            carlot.AddCar("Tesla", "Model S", 2020, 95000, 0);
            carlot.AddCar("Lamgorghini", "Aventador", 2020, 420000, 0);
            carlot.AddCar("Chevy", "Camaro", 2010, 11000, 10000);
            carlot.AddCar("Dodge", "Charger", 2010, 9000, 124000);
            carlot.AddCar("Mercedes-Benz", "G Wagon", 2015, 65000, 35000);

            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("What would you like to do? " +
                "\n1. List all cars" +
                 "\n2. Buy a car" +
                 "\n3. Add a car" +
                 "\n4. Quit");
                Console.Write("Enter choice here: ");

                int switchCase = InputInt();
                while (switchCase < 1 || switchCase > 4)
                {
                    Console.Write("That is not a valid input. Enter the following:" +
                        "\n1. Add a team member" +
                    "\n2. Search for a team member" +
                    "\n3. Print all members" +
                    "\n4. Quit");
                    switchCase = InputInt();
                }

                switch (switchCase)
                {
                    case 1:
                        carlot.ListCars();
                        break;
                    case 2:
                        carlot.ListCars();
                        Console.Write("Enter the ID of the car you would like to buy: ");
                        int id = InputInt();
                        carlot.RemoveCar(id);

                        break;
                    case 3:
                        Console.Write("Make: ");
                        string make = Console.ReadLine();

                        Console.Write("Model: ");
                        string model = Console.ReadLine();

                        Console.Write("Year: ");
                        int year = int.Parse(Console.ReadLine());

                        Console.Write("Price: $");
                        double price = double.Parse(Console.ReadLine());

                        Console.Write("Mileage (enter 0 if new): ");
                        double mileage = double.Parse(Console.ReadLine());

                        carlot.AddCar(make, model, year, price, mileage);
                        break;
                    default:
                        break;

                }

                flag = RunAgainBool("Do you want to continue? y/n: ");
            }
        }

        static int InputInt()
        {

            //Input validation to make sure an int is entered
            bool isValid = int.TryParse(Console.ReadLine(), out int userInput);
            while (!isValid)
            {
                Console.Write("That is not a valid entry. Please enter an integer: ");
                isValid = int.TryParse(Console.ReadLine(), out userInput);
            }

            return userInput;
        }

        static bool RunAgainBool(string message)
        {
            Console.Write(message);
            char key = Console.ReadKey().KeyChar;

            while (key != 'y')
            {
                if (key == 'n')
                {
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    Console.Write("\nThat is an invalid entry. Please enter y or n: ");
                    key = Console.ReadKey().KeyChar;
                }
            }
            Console.WriteLine();
            return true;
        }

    }


}

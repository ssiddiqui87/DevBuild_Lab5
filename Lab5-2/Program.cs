using System;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string inputName = Console.ReadLine();
            bool flag = true;
            while (flag == true)
            {
                Console.Write("Do you want to play against Dwayne Johnson or Kevin Hart? (dj or kh): ");
                string inputPlayer = Console.ReadLine().ToLower();
                while (inputPlayer != "dj" && inputPlayer != "kh")
                {
                    Console.Write("That is not a valid entry. Please enter dj for Dwayne Johnson or kh for Kevin Hart: ");
                    inputPlayer = Console.ReadLine();
                }
                User human = new User(inputName);
                int humanSelection = (int)human.GenerateRoshambo();

                int winner;
                if (inputPlayer == "dj")
                {
                    DwayneJohnson rock = new DwayneJohnson("rock");
                    int rockSelection = (int)rock.GenerateRoshambo();
                    winner = CheckWinner(humanSelection, rockSelection);
                    Console.WriteLine($"You selected: {(Roshambo)humanSelection}\nDwayne Johnson, of course, selected: The Rock");
                    if (winner == 1)
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (winner == 2)
                    {
                        Console.WriteLine("The Rock Layeth The Smacketh Down. You lose!");
                    }
                    else
                    {
                        Console.WriteLine("Tie!");
                    }

                }
                else if (inputPlayer == "kh")
                {

                    KevinHart kh = new KevinHart("kh");
                    int khSelection = (int)kh.GenerateRoshambo();
                    winner = CheckWinner(humanSelection, khSelection);
                    Console.WriteLine($"You selected: {(Roshambo)humanSelection}\nKevin Hart chose: {(Roshambo)khSelection}");

                    if (winner == 1)
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (winner == 2)
                    {
                        Console.WriteLine("You lose!");
                    }
                    else
                    {
                        Console.WriteLine("Tie!");
                    }

                }
                Console.WriteLine();
                flag = RunAgainBool("Do you want to play again? (y/n): ");
            }
        }
        static int CheckWinner(int player1, int player2)
        {
            if (player1 == player2)
            {
                return 0;
            }
            else if (player1 == 2)
            {
                if (player2 == 0)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
            else if (player2 == 2)
            {
                if (player1 == 0)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if (player1 < player2)
            {
                return 2;
            }
            else
            {
                return 1;
            }
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

        //static void CheckWinner(int player1, int player2)
        //{
        //    if (player1 == player2)
        //    {
        //        Console.WriteLine("Tie!");
        //    }
        //    else if (player1 == 2)
        //    {
        //        if (player2 == 0)
        //        {
        //            Console.WriteLine("Player 2 wins");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Player 1 wins");
        //        }
        //    }
        //    else if (player2 == 2)
        //    {
        //        if (player1 == 0)
        //        {
        //            Console.WriteLine("Player 1 wins");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Player 2 wins");
        //        }
        //    }
        //    else if (player1 < player2)
        //    {
        //        Console.WriteLine("Player 2 wins");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Player 1 wins");
        //    }
        //}
    }
}

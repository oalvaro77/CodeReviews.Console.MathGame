using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame2
{
    internal class Menu
    {
        public void MainMenu()
        {
            string input;
            do
            {
                Console.WriteLine("====== Main Menu ====== ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Game History");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter your choice:");
                input = Console.ReadLine();
                Int32.TryParse(input, out int val);
                Operation operation = new Operation();
                switch (val)
                {
                    case 1:
                        operation.Addition("You selected Addition.");
                        break;
                    case 2:
                        Console.WriteLine("You selected Subtraction.");
                        break;
                    case 3:
                        operation.Multiplication("You selected Multiplication.");
                        break;
                    case 4:
                        operation.Division("You selected Division.");
                        break;
                    case 5:
                        Helpers.PrintHistory();
                        break;
                    case 6:
                        Console.WriteLine("Exiting the game. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (input != "6");
        }
    }
}


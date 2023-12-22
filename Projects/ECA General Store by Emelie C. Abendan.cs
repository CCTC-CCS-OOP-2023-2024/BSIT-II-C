using System;

namespace ECA_General_Store
{
    class Program
    {
        // Module 1: Getting started
        static void Main(string[] args)
        {
            // Module 1: Basic Concepts (Output)
            Console.WriteLine("Welcome to E.C.A General Store!");
            Console.WriteLine("We sell pizza and milk tea.");

            // Module 1: Variables
            int pizzaChoice;
            int pizzaSize;
            int milkTeaChoice;
            int milkTeaSize;
            double pizzaPrice;
            double milkTeaPrice;
            double totalPrice;

            // Module 2: User Input
            Console.WriteLine("Please enter your order:");
            Console.WriteLine("1. Margherita");
            Console.WriteLine("2. Pepperoni");
            Console.Write("Pizza choice: ");
            pizzaChoice = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the size of your pizza:");
            Console.WriteLine("1. 12-inch");
            Console.WriteLine("2. 14-inch");
            Console.Write("Pizza size: ");
            pizzaSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your drink:");
            Console.WriteLine("1. Classic Milk Tea");
            Console.WriteLine("2. Taro Milk Tea");
            Console.Write("Milk tea choice: ");
            milkTeaChoice = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the size of your milk tea:");
            Console.WriteLine("1. Regular");
            Console.WriteLine("2. Large");
            Console.Write("Milk tea size: ");
            milkTeaSize = int.Parse(Console.ReadLine());

            // Module 3: Decision Making
            // Module 3: if Statement
            // Module 3: else if Statement
            // Module 3: else Statement
            // Module 3: switch Statement
            // Module 3: Ternary Operator
            switch (pizzaChoice)
            {
                case 1:
                    pizzaPrice = pizzaSize == 1 ? 12 : 14;
                    break;
                case 2:
                    pizzaPrice = pizzaSize == 1 ? 14 : 16;
                    break;
                default:
                    pizzaPrice = 0;
                    break;
            }

            switch (milkTeaChoice)
            {
                case 1:
                    milkTeaPrice = milkTeaSize == 1 ? 14 : 16;
                    break;
                case 2:
                    milkTeaPrice = milkTeaSize == 1 ? 14 : 16;
                    break;
                default:
                    milkTeaPrice = 0;
                    break;
            }

            // Module 1: Doing Math
            // Module 2: Arithmetic Operators
            // Module 2: Assignment Operators
            totalPrice = pizzaPrice + milkTeaPrice;

            // Module 2: More on Strings (\n \t @)
            // Module 2: Concatenation and Interpolation
            Console.WriteLine("\nYour order summary:");
            Console.WriteLine($"\tPizza: {pizzaChoice} - {pizzaSize}");
            Console.WriteLine($"\tMilk tea: {milkTeaChoice} - {milkTeaSize}");
            Console.WriteLine($"\tTotal price: {totalPrice}");

            // Module 4: Loops
            // Module 4: for Loop
            // Module 4: while Loop
            // Module 4: break and continue
            Console.WriteLine("\nPlease enter your payment amount:");
            double payment = 0;
            for (int i = 0; i < 3; i++)
            {
                payment = double.Parse(Console.ReadLine());
                if (payment < totalPrice)
                {
                    Console.WriteLine("Insufficient payment. Please try again.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            while (payment < totalPrice)
            {
                Console.WriteLine("Sorry, you have exceeded the maximum number of attempts.");
                Console.WriteLine("Please contact the store manager for assistance.");
                return;
            }

            // Module 5: Methods
            // Module 5: Parameters and Arguments
            // Module 5: Returning from Methods
            double change = CalculateChange(payment, totalPrice);
            Console.WriteLine($"\nYour change is {change}");
            Console.WriteLine("Thank you for your purchase!");
            Console.WriteLine("Have a nice day!");
        }

        // Module 5: Methods
        static double CalculateChange(double payment, double totalPrice)
        {
            // Module 2: Arithmetic Operators
            return payment - totalPrice;
        }
    }
}

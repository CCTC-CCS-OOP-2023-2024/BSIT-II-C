using System;

namespace FlavorsofTheEast
{
    class Program
    {
        // Module 1 - Getting started
        static void Main(string[] args)
        {
            // Basic Concepts (Output)
            Console.WriteLine("Welcome to Flavors of The East!");

            // Variables
            string name;
            int choice;

            // Data Types
            double price;
            bool valid;

            // Module 2 - Operators and Strings
            // User Input
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            // More on Strings (\n \t @)
            Console.WriteLine("\nHello, {0}! Here are the available meals:\n", name);
            Console.WriteLine("\t1. LUMPIANG SHANGHAI P195\n\t2. CHICKEN KEBAB P225\n\t3. FRIED CHICKEN P225\n\t4. PORK BARBECUE P205\n\t5. SISIG P205");

            // Module 3 - Decision Making
            // Comparison Operators
            // Logical Operators
            // if Statement
            // else if Statement
            // else Statement
            // Ternary Operator
            do
            {
                valid = true;
                Console.Write("\nPlease enter your choice (1-5): ");
                choice = int.Parse(Console.ReadLine());
                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    valid = false;
                }
            } while (!valid);

            price = choice == 1 ? 195 : choice == 2 || choice == 3 ? 225 : 205;

            // Module 4 - Loops
            // for Loop
            // break and continue
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Do you want a glass of iced tea? (y/n): ");
                char answer = char.Parse(Console.ReadLine());
                if (answer == 'y' || answer == 'Y')
                {
                    price += 25;
                    break;
                }
                else if (answer == 'n' || answer == 'N')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid answer. Please try again.");
                    continue;
                }
            }

            // Module 5 - Methods
            // Parameters and Arguments
            // Returning from Methods
            Console.WriteLine("\nYour total bill is {0}", ComputeTotal(price));
            Console.WriteLine("Thank you for choosing Flavors of The East!");
        }

        // A method that computes the total amount with tax
        static double ComputeTotal(double amount)
        {
            // Doing Math
            // Assignment Operators
            // Arithmetic Operators
            amount *= 1.12; // 12% tax
            return amount;
        }
    }
}
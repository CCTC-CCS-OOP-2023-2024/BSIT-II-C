using System;

namespace BurgerPatty
{
    class Program
    {
        static void Main()
        {
            // Program Structure
            Console.WriteLine("Welcome to BurgerPatty Program!");

            // Variables
            int quantity;
            double pricePerPatty;
            string pattyType = "Flame Grilled Cheese";

            // User Input
            Console.Write("Enter quantity: ");
            quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter price per patty: $");
            pricePerPatty = double.Parse(Console.ReadLine());

            Console.Write("Enter patty type (beef or chicken): ");
            pattyType = Console.ReadLine();

            // Doing Math
            double totalCost = quantity * pricePerPatty;

            // Output
            Console.WriteLine($"Order Details:\n\tPatty Type: {pattyType}\n\tQuantity: {quantity}\n\tTotal Cost: ${totalCost}");

            // More on Strings (\n \t @)
            Console.WriteLine("This is Patrick Casagnap\n\tOwner of\n\tBurgerPatty Program");

            // Concatenation and Interpolation
            string orderSummary = "Order Summary:\n" +
                                  "\tPatty Type: " + pattyType + "\n" +
                                  "\tQuantity: " + quantity + "\n" +
                                  "\tTotal Cost: $" + totalCost;

            Console.WriteLine(orderSummary);

            // Comparison Operators
            if (quantity > 1)
            {
                Console.WriteLine("You ordered more than one patty.");
            }
            else if (quantity == 1)
            {
                Console.WriteLine("You ordered one patty.");
            }
            else
            {
                Console.WriteLine("Invalid quantity.");
            }

            // Logical Operators
            if (pricePerPatty > 0 && quantity > 0)
            {
                Console.WriteLine("Valid price and quantity.");
            }

            // switch Statement
            switch (pattyType.ToLower())
            {
                case "beef":
                    Console.WriteLine("Beef patty selected.");
                    break;
                case "chicken":
                    Console.WriteLine("Chicken patty selected.");
                    break;
                default:
                    Console.WriteLine("Unknown patty type.");
                    break;
            }

            // Ternary Operator
            string message = (totalCost > 10) ? "High total cost" : "Low total cost";
            Console.WriteLine(message);

            // for Loop
            Console.WriteLine("Looping through the quantity of patties:");
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Patty {i + 1}");
            }

            // while Loop
            Console.WriteLine("Looping with while loop:");
            int counter = 0;
            while (counter < quantity)
            {
                Console.WriteLine($"Burger {counter + 1}");
                counter++;
            }

            // break and continue
            Console.WriteLine("Using break and continue in a loop:");
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }

                if (i == 4)
                {
                    break;
                }

                Console.WriteLine($"Patrickkk {i + 1}");
            }

            // Methods
            DisplayThankYouMessage();

            // Parameters and Arguments
            PrintOrderDetails(pattyType, quantity, totalCost);

            // Returning from Methods
            double discount = CalculateDiscount(totalCost);
            Console.WriteLine($"Discount applied: ${discount}");

            Console.ReadLine();
        }

        // Method example
        static void DisplayThankYouMessage()
        {
            Console.WriteLine("Thank you for using BurgerPatty Program!");
        }

        static void PrintOrderDetails(string type, int quantity, double total)
        {
            Console.WriteLine($"Order Details in Method:\n\tPatty Type: {type}\n\tQuantity: {quantity}\n\tTotal Cost: ${total}");
        }

        static double CalculateDiscount(double total)
        {
            // Apply a simple discount of 5% for demonstration purposes
            double discountPercentage = 0.05;
            double discount = total * discountPercentage;
            return discount;
        }
    }
}

using System;

namespace ECA_General_Store
{
    class Program
    {
        // Module 5: Methods
        // A method to display the menu of the store
        static void DisplayMenu()
        {
            Console.WriteLine("Welcome to E.C.A General Store!");
            Console.WriteLine("Here is our menu:\n");

            Console.WriteLine("Ice Cream:");
            Console.WriteLine("Chocolate Fudge - P13.50 per scoop");
            Console.WriteLine("Vanilla Bean - P13.50 per scoop\n");

            Console.WriteLine("Pizza:");
            Console.WriteLine("Margherita - P12.00 for a 12-inch pizza");
            Console.WriteLine("Pepperoni - P14.00 for a 12-inch pizza\n");

            Console.WriteLine("Milk Tea:");
            Console.WriteLine("Classic Milk Tea - P14.00 for a regular size");
            Console.WriteLine("Taro Milk Tea - P14.50 for a regular size\n");
        }

        // A method to calculate the total price of the order
        // It takes the quantity and price of each item as parameters
        // It returns the total price as a double
        static double CalculateTotal(int iceCreamQty, double iceCreamPrice, int pizzaQty, double pizzaPrice, int milkTeaQty, double milkTeaPrice)
        {
            // Module 2: Arithmetic Operators
            // Module 3: Ternary Operator
            // Apply a 10% discount if the order is more than P100
            double subtotal = iceCreamQty * iceCreamPrice + pizzaQty * pizzaPrice + milkTeaQty * milkTeaPrice;
            double discount = subtotal > 100 ? 0.1 : 0;
            double total = subtotal * (1 - discount);

            return total;
        }

        // Module 1: Program Structure
        // The main method of the program
        static void Main(string[] args)
        {
            // Module 1: Variables and Data Types
            // Declare variables to store the quantity and price of each item
            int iceCreamQty = 0;
            double iceCreamPrice = 13.5;
            int pizzaQty = 0;
            double pizzaPrice = 0;
            int milkTeaQty = 0;
            double milkTeaPrice = 0;

            // Module 2: User Input
            // Ask the user for their order
            DisplayMenu();
            Console.WriteLine("Please enter your order below:");

            Console.Write("How many scoops of ice cream do you want? ");
            iceCreamQty = int.Parse(Console.ReadLine());

            Console.Write("How many pizzas do you want? ");
            pizzaQty = int.Parse(Console.ReadLine());

            // Module 3: Decision Making
            // Use a switch statement to assign the price of the pizza based on the user's choice
            Console.Write("What kind of pizza do you want? (M for Margherita, P for Pepperoni) ");
            char pizzaChoice = char.Parse(Console.ReadLine().ToUpper());
            switch (pizzaChoice)
            {
                case 'M':
                    pizzaPrice = 12;
                    break;
                case 'P':
                    pizzaPrice = 14;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter M or P.");
                    break;
            }

            Console.Write("How many milk teas do you want? ");
            milkTeaQty = int.Parse(Console.ReadLine());

            // Use an if-else statement to assign the price of the milk tea based on the user's choice
            Console.Write("What kind of milk tea do you want? (C for Classic, T for Taro) ");
            char milkTeaChoice = char.Parse(Console.ReadLine().ToUpper());
            if (milkTeaChoice == 'C')
            {
                milkTeaPrice = 14;
            }
            else if (milkTeaChoice == 'T')
            {
                milkTeaPrice = 14.5;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter C or T.");
            }

            // Module 4: Loops
            // Use a while loop to validate the user's order
            bool validOrder = false;
            while (!validOrder)
            {
                // Module 1: Basic Concepts (Output)
                // Module 2: Concatenation and Interpolation
                // Display the user's order summary
                Console.WriteLine("\nHere is your order summary:");
                Console.WriteLine($"Ice Cream: {iceCreamQty} scoop(s) @ P{iceCreamPrice} per scoop");
                Console.WriteLine($"Pizza: {pizzaQty} pizza(s) of {pizzaChoice} @ P{pizzaPrice} per pizza");
                Console.WriteLine($"Milk Tea: {milkTeaQty} cup(s) of {milkTeaChoice} @ P{milkTeaPrice} per cup");

                // Module 5: Parameters and Arguments
                // Module 5: Returning from Methods
                // Call the CalculateTotal method to get the total price of the order
                double totalPrice = CalculateTotal(iceCreamQty, iceCreamPrice, pizzaQty, pizzaPrice, milkTeaQty, milkTeaPrice);
                Console.WriteLine($"Total Price: P{totalPrice}");

                // Ask the user if they want to confirm or cancel their order
                Console.Write("\nDo you want to confirm or cancel your order? (Y for confirm, N for cancel) ");
                char orderChoice = char.Parse(Console.ReadLine().ToUpper());

                // Use an if-else statement to handle the user's choice
                if (orderChoice == 'Y')
                {
                    Console.WriteLine("Thank you for your order. Have a nice day!");
                    validOrder = true;
                }
                else if (orderChoice == 'N')
                {
                    Console.WriteLine("Your order has been cancelled. Please try again.");
                    validOrder = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter Y or N.");
                    validOrder = false;
                }

                // Module 4: break and continue
                // Use a break statement to exit the loop if the order is valid
                if (validOrder)
                {
                    break;
                }

                // Use a continue statement to restart the loop if the order is invalid
                else
                {
                    continue;
                }
            }
        }
    }
}
using System;

namespace McDollibeeApp
{
    class Ruiz
    {
        static void Main()
        {

            Console.WriteLine("Welcome to McDollibee App!");


            int burgerPrice = 5;
            double drinkPrice = 2.5;
            int friesPrice = 3;


            int orderNumber = 101;
            double totalPrice;


            int numberOfBurgers = 2;
            int numberOfFries = 1;


            int burgersCost = numberOfBurgers * burgerPrice;
            double totalCost = burgersCost + (numberOfFries * friesPrice);


            totalPrice = totalCost;


            Console.Write("Enter your drink size (small/medium/large): ");
            string drinkSize = Console.ReadLine();


            string receipt = $"Order Number: {orderNumber}\n\tBurgers: {numberOfBurgers}\n\tFries: {numberOfFries}\n\tDrink Size: {drinkSize}";


            string orderSummary = "Your order includes " + numberOfBurgers + " burgers, " + numberOfFries + " fries, and a " + drinkSize + " drink.";


            if (totalCost > 10)
            {
                Console.WriteLine("You qualify for a free toy with your meal!");
            }
            else if (totalCost > 5)
            {
                Console.WriteLine("Upgrade your drink size for a bigger portion!");
            }
            else
            {
                Console.WriteLine("Enjoy your meal!");
            }


            bool isLargeDrink = (drinkSize.ToLower() == "large");
            if (isLargeDrink && numberOfBurgers >= 2)
            {
                Console.WriteLine("You've chosen a large drink and ordered multiple burgers. Great choice!");
            }


            Console.Write("Enter your preferred sauce (ketchup/mustard/mayo): ");
            string sauceChoice = Console.ReadLine();
            switch (sauceChoice.ToLower())
            {
                case "ketchup":
                    Console.WriteLine("Ketchup adds a tangy flavor to your meal.");
                    break;
                case "mustard":
                    Console.WriteLine("Mustard provides a zesty kick to your taste buds.");
                    break;
                case "mayo":
                    Console.WriteLine("Mayonnaise adds a creamy texture to your dish.");
                    break;
                default:
                    Console.WriteLine("Invalid sauce choice. Please select ketchup, mustard, or mayo.");
                    break;
            }


            string toyMessage = (totalCost > 10) ? "Enjoy your free toy!" : "No free toy with this order.";
            Console.WriteLine(toyMessage);


            Console.WriteLine("Counting from 1 to 3:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Counting down from 5:");
            int countdown = 7;
            while (countdown > 0)
            {
                Console.WriteLine(countdown);
                countdown--;
            }


            Console.WriteLine("Skipping 2 in a loop:");
            for (int i = 1; i <= 6; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            DisplayOrderSummary(receipt);


            DisplayCustomMessage("Thank you for choosing McDonald's!");


            double change = ProcessPayment(20, totalCost);
            Console.WriteLine($"Your change: {change:C}");
        }

        static void DisplayOrderSummary(string orderDetails)
        {
            Console.WriteLine("Order Summary:");
            Console.WriteLine(orderDetails);
        }

        static void DisplayCustomMessage(string message)
        {
            Console.WriteLine(message);
        }

        static double ProcessPayment(double amountPaid, double totalAmount)
        {
            double change = amountPaid - totalAmount;
            return change;
        }
    }
}
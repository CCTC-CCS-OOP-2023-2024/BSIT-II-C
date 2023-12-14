using System;

namespace UnliWings
{
    class PURISIMA
    {
        static void Main()
        {

            Console.WriteLine("Welcome to UnliWings App!");


            int ChickenWingsPrice = 190;
            double drinkPrice = 25;
            int friesPrice = 3;


            int orderNumber = 69
             ;
            double totalPrice;


            int numberOfChickenWings = 2;
            int numberOfFries = 1;


            int ChickenWingsCost = numberOfChickenWings * ChickenWingsPrice;
            double totalCost = ChickenWingsCost + (numberOfFries * friesPrice);


            totalPrice = totalCost;


            Console.Write("Enter your drink size (small/medium/large): ");
            string drinkSize = Console.ReadLine();


            string receipt = $"Order Number: {orderNumber}\n\tChickenWings: {numberOfChickenWings}\n\tFries: {numberOfFries}\n\tDrink Size: {drinkSize}";


            string orderSummary = "Your order includes " + numberOfChickenWings + " burgers, " + numberOfFries + " fries, and a " + drinkSize + " drink.";


            if (totalCost > 10)
            {
                Console.WriteLine("You qualify for a free CAP for your ChickenWings!");
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
            if (isLargeDrink && numberOfChickenWings >= 2)
            {
                Console.WriteLine("You've chosen a large drink and ordered multiple burgers. Great choice!");
            }


            Console.Write("Enter your preferred sauce (ketchup/mustard/mayo): ");
            string sauceChoice = Console.ReadLine();
            switch (sauceChoice.ToLower())
            {
                case "ketchup":
                    Console.WriteLine("Ketchup adds a tangy flavor to your ChickenWings.");
                    break;
                case "mustard":
                    Console.WriteLine("Mustard provides a zesty kick to your taste buds.");
                    break;
                case "mayo":
                    Console.WriteLine("Mayonnaise adds a creamy texture to your ChickenWings.");
                    break;
                default:
                    Console.WriteLine("Invalid sauce choice. Please select ketchup, mustard, or mayo.");
                    break;
            }


            string toyMessage = (totalCost > 10) ? "Enjoy your free CAP!" : "No free CAP with this order.";
            Console.WriteLine(toyMessage);


            Console.WriteLine("Counting from 1 to 3:");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Counting down from 5:");
            int countdown = 5;
            while (countdown > 0)
            {
                Console.WriteLine(countdown);
                countdown--;
            }


            Console.WriteLine("Skipping 2 in a loop:");
            for (int i = 1; i <= 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            DisplayOrderSummary(receipt);


            DisplayCustomMessage("Thank you for choosing UnliWings!");


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
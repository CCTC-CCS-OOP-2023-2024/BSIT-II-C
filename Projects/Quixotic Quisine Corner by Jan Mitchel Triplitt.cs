using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Welcome to Quixotic Quisine Corner!");

        
        int beveragePrice = 3;
        double snackPrice = 2.25;
        int dessertPrice = 4;

        
        int orderNumber = 501;
        double totalPrice;

       
        int numberOfBeverages = 4;
        int numberOfSnacks = 5;

        
        int beverageCost = numberOfBeverages * beveragePrice;
        double totalCost = beverageCost + (numberOfSnacks * snackPrice);

        
        totalPrice = totalCost;

        
        Console.Write("Enter your favorite dessert (cake/pie/ice cream): ");
        string dessertChoice = Console.ReadLine();

        
        string receipt = $"Order Number: {orderNumber}\n\tBeverages: {numberOfBeverages}\n\tSnacks: {numberOfSnacks}\n\tDessert Choice: {dessertChoice}";

        
        string orderSummary = $"Your order includes {numberOfBeverages} beverages, {numberOfSnacks} snacks, and a {dessertChoice} dessert.";


        if (totalCost > 20)
        {
            Console.WriteLine("You qualify for a discount on your next visit!");
        }
        else if (totalCost > 15)
        {
            Console.WriteLine("Upgrade to a larger size for a special treat!");
        }
        else
        {
            Console.WriteLine("Enjoy your time at Quixotic Quisine Corner!");
        }

        
        bool isIceCreamDessert = (dessertChoice.ToLower() == "ice cream");
        if (isIceCreamDessert && numberOfBeverages >= 3)
        {
            Console.WriteLine("Ice cream as a dessert pairs well with our variety of beverages. Enjoy!");
        }

        
        Console.Write("Enter your preferred snack flavor (spicy/sweet/savory): ");
        string snackFlavor = Console.ReadLine();
        switch (snackFlavor.ToLower())
        {
            case "spicy":
                Console.WriteLine("Spicy snacks add a kick to your taste buds.");
                break;
            case "sweet":
                Console.WriteLine("Sweet snacks satisfy your cravings for a sugary delight.");
                break;
            case "savory":
                Console.WriteLine("Savory snacks offer a savory and flavorful experience.");
                break;
            default:
                Console.WriteLine("Invalid snack flavor choice. Please select spicy, sweet, or savory.");
                break;
        }

        string discountMessage = (totalCost > 20) ? "You've earned a discount for your loyalty!" : "No discount with this order.";
        Console.WriteLine(discountMessage);

        
        Console.WriteLine("Counting from 1 to 5:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        
        Console.WriteLine("Counting down from 8:");
        int countdown = 8;
        while (countdown > 0)
        {
            Console.WriteLine(countdown);
            countdown--;
        }

        
        Console.WriteLine("Skipping 4 in a loop:");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 4)
            {
                continue;
            }
            Console.WriteLine(i);
        }

        
        DisplayOrderReceipt(receipt);

        
        DisplayThankYouMessage("Thank you for choosing Quixotic Quisine Corner!");

        
        double change = ProcessPayment(25, totalCost);
        Console.WriteLine($"Your change: {change:C}");
    }

    static void DisplayOrderReceipt(string orderDetails)
    {
        Console.WriteLine("Order Receipt:");
        Console.WriteLine(orderDetails);
    }

    static void DisplayThankYouMessage(string message)
    {
        Console.WriteLine(message);
    }

    static double ProcessPayment(double amountPaid, double totalAmount)
    {
        double change = amountPaid - totalAmount;
        return change;
    }
}
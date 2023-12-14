using System;

namespace Pinakalamiang_Siomai { 

class Ramos
{
    static void Main()
    {

        Console.WriteLine("Welcome to PINAKALAMIANG SIOMAI");


        int siomai = 35;
        double drinkPrice = 25;
        int friedSiomai = 30;


        int orderNumber = 120
         ;
        double totalPrice;


        int numberofsiomai = 2;
        int numberoffriedsiomai = 1;


        int siomaicost = numberofsiomai * siomai;
        double totalCost = siomai + (numberoffriedsiomai * friedSiomai);


        totalPrice = totalCost;


        Console.Write("Enter your drink size (small/medium/large): ");
        string drinkSize = Console.ReadLine();


        string receipt = $"Order Number: {orderNumber}\n\t Siomai: {numberofsiomai}\n\t Fried Siomai: {numberoffriedsiomai}\n\t Drink Size: {drinkSize}";


        string orderSummary = "Your order includes " + numberofsiomai + " lumpia, " + numberoffriedsiomai + " siomai, and a " + drinkSize + " drink.";


        if (totalCost > 10)
        {
            Console.WriteLine("You qualify for a free CAP for your Siomai!");
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
        if (isLargeDrink && numberofsiomai >= 2)
        {
            Console.WriteLine("You've chosen a large drink and ordered multiple lumpia. Great choice!");
        }


        Console.Write("Enter your preferred sauce (ketchup/soysauce/vinegar): ");
        string sauceChoice = Console.ReadLine();
        switch (sauceChoice.ToLower())
        {
            case "ketchup":
                Console.WriteLine("Ketchup adds a tangy flavor to your siomai.");
                break;
            case "soysauce":
                Console.WriteLine("Soysauce provides a zesty kick to your taste buds.");
                break;
            case "vinegar":
                Console.WriteLine("Vinegar adds a sour flavor to your siomai.");
                break;
            default:
                Console.WriteLine("Invalid sauce choice. Please select ketchup, soysauce, or vinegar.");
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


        DisplayCustomMessage("Thank you for choosing Pinakalamiang Siomai!");


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
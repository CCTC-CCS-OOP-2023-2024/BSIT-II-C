using System;

class CafedeSecreto
{
    static void Main()
    {
        // Program Structure
        Console.WriteLine("Welcome to class Cafe de Secreto!");

        // Variables
        int coffeePrice = 4;
        double pastryPrice = 2.75;
        int teaPrice = 3;

        // Data Types
        int orderNumber = 401;
        double totalPrice;

        // Doing Math
        int numberOfCoffees = 3;
        int numberOfPastries = 2;

        // Arithmetic Operators
        int coffeeCost = numberOfCoffees * coffeePrice;
        double totalCost = coffeeCost + (numberOfPastries * pastryPrice);

        // Assignment Operators
        totalPrice = totalCost;

        // User Input
        Console.Write("Enter your preferred tea type (black/green/herbal): ");
        string teaType = Console.ReadLine();

        // More on Strings (\n \t @)
        string receipt = $"Order Number: {orderNumber}\n\tCoffees: {numberOfCoffees}\n\tPastries: {numberOfPastries}\n\tTea Type: {teaType}";

        // Concatenation and Interpolation
        string orderSummary = $"Your order includes {numberOfCoffees} coffees, {numberOfPastries} pastries, and a {teaType} tea.";

        // Comparison Operators
        if (totalCost > 15)
        {
            Console.WriteLine("You qualify for a discount on your next purchase!");
        }
        else if (totalCost > 10)
        {
            Console.WriteLine("Add a special pastry to your order for a discount!");
        }
        else
        {
            Console.WriteLine("Enjoy your time at Cafe de Secreto!");
        }

        // Logical Operators
        bool isHerbalTea = (teaType.ToLower() == "herbal");
        if (isHerbalTea && numberOfCoffees >= 2)
        {
            Console.WriteLine("Herbal tea complements well with our coffee selection. Enjoy!");
        }

        // switch Statement
        Console.Write("Enter your preferred pastry flavor (chocolate/vanilla/fruit): ");
        string pastryFlavor = Console.ReadLine();
        switch (pastryFlavor.ToLower())
        {
            case "chocolate":
                Console.WriteLine("Indulge in the rich flavor of our chocolate pastries.");
                break;
            case "vanilla":
                Console.WriteLine("Savor the sweet aroma of our vanilla pastries.");
                break;
            case "fruit":
                Console.WriteLine("Experience the freshness of our fruit-flavored pastries.");
                break;
            default:
                Console.WriteLine("Invalid pastry flavor choice. Please select chocolate, vanilla, or fruit.");
                break;
        }

        // Ternary Operator
        string discountMessage = (totalCost > 15) ? "You've earned a discount for your loyalty!" : "No discount with this order.";
        Console.WriteLine(discountMessage);

        // for Loop
        Console.WriteLine("Counting from 1 to 4:");
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine(i);
        }

        // while Loop
        Console.WriteLine("Counting down from 7:");
        int countdown = 7;
        while (countdown > 0)
        {
            Console.WriteLine(countdown);
            countdown--;
        }

        // break and continue
        Console.WriteLine("Skipping 3 in a loop:");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue;
            }
            Console.WriteLine(i);
        }

        // Methods
        DisplayOrderReceipt(receipt);

        // Parameters and Arguments
        DisplayThankYouMessage("Thank you for choosing Cafe de Secreto!");

        // Returning from Methods
        double change = ProcessPayment(30, totalCost);
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
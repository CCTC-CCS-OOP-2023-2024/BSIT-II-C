using System;

class Program
{
    static void Main()
    {
        // Program Structure
        Console.WriteLine("Welcome to N's Supermarket");

        // Variables and Data Types
        int TumblerSold = 19;
        double pricePerTumbler = 150.99;
        string TumblerModel = "BlueTumbler";

        // Doing Math
        double totalRevenue = TumblerSold * pricePerTumbler;

        // More on Strings
        Console.WriteLine($"Tumbler Model: {TumblerModel}\nTumbler Sold: {TumblerSold}\nPrice per Tumbler: ${pricePerTumbler}");

        // Concatenation and Interpolation
        string greetings = "Thank you for Buying in N's Supermarket";
        Console.WriteLine(greetings);

        // Comparison Operators
        if (TumblerSold > 0)
        {
            Console.WriteLine("Tumblers are available!");
        }
        else if (TumblerSold == 0)
        {
            Console.WriteLine("Out of stock.");
        }
        else
        {
            Console.WriteLine("Invalid Tumbler Quantity");
        }

        // Logical Operators
        bool isDisAvailable = true;
        if (TumblerSold > 10 && isDisAvailable)
        {
            Console.WriteLine("You qualify for a discount!");
        }

        // switch Statement
        string cusRating = "Great";
        switch (cusRating)
        {
            case "Excellent":
                Console.WriteLine("Thank you for your great rating!");
                break;
            case "Good":
                Console.WriteLine("We appreciate your nice feedback!");
                break;
            default:
                Console.WriteLine("We appreciate your feedback!");
                break;
        }

        // Ternary Operator
        string status = (TumblerSold > 0) ? "Available" : "Out of stock";
        Console.WriteLine($"Status: {status}");

        // for Loop
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Helping customer {i}");
        }

        // while Loop
        int restockCount = 0;
        while (restockCount < 8)
        {
            Console.WriteLine($"Restocking Tumbler INventory. Restock count: {restockCount + 1}");
            restockCount++;
        }

        // break and continue
        for (int i = 4; i <= 12; i++)
        {
            if (i % 4 == 0)
                continue; // Skip even Tumbler
            Console.WriteLine($"Helping with Tumbler {i}");
        }

        // Methods, Parameters, and Returning from Methods
        double disTotalRevenue = CalculateDiscountedTotal(totalRevenue, 0.1);
        Console.WriteLine($"Discounted Total Revenue: ${disTotalRevenue}");
    }

    // Method with parameters and return statement
    static double CalculateDiscountedTotal(double total, double discountRate)
    {
        return total - (total * discountRate);
    }
}

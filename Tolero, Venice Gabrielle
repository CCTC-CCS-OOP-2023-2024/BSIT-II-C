// Program Structure

using System;

class Program
{
    static void Main()
    {
        // Basic Concepts 
        Console.WriteLine("Welcome to Quixotic Quisine Corner!");

        // Variables and Data Types
        int dishesServed = 10;
        double pricePerDish = 350.99;
        string dishType = "Grand Velas Tacos";

        // Doing Math
        double totalRevenue = dishesServed * pricePerDish;

        // More on Strings
        Console.WriteLine($"Dish Type: {dishType}\nDishes Served: {dishesServed}\nPrice per Dish: ${pricePerDish}");

        // Concatenation and Interpolation
        string welcomeMessage = "Indulge in the flavors of Quixotic Quisine Corner!";
        Console.WriteLine(welcomeMessage);

        // Comparison Operators
        if (dishesServed > 0)
        {
            Console.WriteLine("Dishes are available.");
        }
        else if (dishesServed == 0)
        {
            Console.WriteLine("Out of stock.");
        }
        else
        {
            Console.WriteLine("Invalid quantity of dishes.");
        }

        // Logical Operators
        bool isDiscountAvailable = true;
        if (dishesServed > 20 && isDiscountAvailable)
        {
            Console.WriteLine("You qualify for a discount!");
        }

        // switch Statement
        string customerMood = "Happy";
        switch (customerMood)
        {
            case "Happy":
                Console.WriteLine("We're delighted you're enjoying your meal at Quixotic Quisine Corner!");
                break;
            case "Neutral":
                Console.WriteLine("We hope to make your experience better!");
                break;
            default:
                Console.WriteLine("Let us know how we can improve!");
                break;
        }

        // Ternary Operator
        string status = (dishesServed > 0) ? "Available" : "Out of stock";
        Console.WriteLine($"Status: {status}");

        // for Loop
        for (int i = 1; i <= 8; i++)
        {
            Console.WriteLine($"Serving customer {i}");
        }

        // while Loop
        int restockCount = 0;
        while (restockCount < 3)
        {
            Console.WriteLine($"Restocking supplies. Restock count: {restockCount + 1}");
            restockCount++;
        }

        // break and continue
        for (int i = 1; i <= 8; i++)
        {
            if (i % 2 == 0)
                continue; // Skip even dishes
            Console.WriteLine($"Serving dish {i}");
        }

        // Methods, Parameters, and Returning from Methods
        double discountedTotalRevenue = CalculateDiscountedTotal(totalRevenue, 0.15);
        Console.WriteLine($"Discounted Total Revenue: ${discountedTotalRevenue}");
    }

    // Method with parameters and return statement
    static double CalculateDiscountedTotal(double total, double discountRate)
    {
        return total - (total * discountRate);
    }
}

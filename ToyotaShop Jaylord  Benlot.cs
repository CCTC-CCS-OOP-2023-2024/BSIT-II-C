using System;

class Program
{
    static void Main()
    {
        // Program Structure
        Console.WriteLine("Welcome to lordj TOYOTA Shop!");

        // Variables and Data Types
        int vehicleSold = 16;
        double pricePerVehicle = 123.99;
        string VehicleModel = "Toyota Furtuner";

        // Doing Math
        double totalRevenue = vehicleSold * pricePerVehicle;

        // More on Strings
        Console.WriteLine($"Bike Model: {VehicleModel}\nVehicle Sold: {vehicleSold}\nPrice per Vehicle: ${pricePerVehicle}");

        // Concatenation and Interpolation
        string greeting = "Thank you for choosing lordj TOYOTA SHOP!";
        Console.WriteLine(greeting);

        // Comparison Operators
        if (vehicleSold > 0)
        {
            Console.WriteLine("Vehicles are available.");
        }
        else if (vehicleSold == 0)
        {
            Console.WriteLine("Out of stock.");
        }
        else
        {
            Console.WriteLine("Invalid vehicle quantity.");
        }

        // Logical Operators
        bool isDiscountAvailable = true;
        if (vehicleSold > 10 && isDiscountAvailable)
        {
            Console.WriteLine("You qualify for a discount!");
        }

        // switch Statement
        string customerRating = "Excellent";
        switch (customerRating)
        {
            case "Excellent":
                Console.WriteLine("Thank you for your excellent rating!");
                break;
            case "Good":
                Console.WriteLine("We appreciate your positive feedback!");
                break;
            default:
                Console.WriteLine("We value your feedback!");
                break;
        }

        // Ternary Operator
        string status = (vehicleSold > 0) ? "Available" : "Out of stock";
        Console.WriteLine($"Status: {status}");

        // for Loop
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine($"Assisting customer {i}");
        }

        // while Loop
        int restockCount = 0;
        while (restockCount < 3)
        {
            Console.WriteLine($"Restocking vehicle inventory. Restock count: {restockCount + 1}");
            restockCount++;
        }

        // break and continue
        for (int i = 2; i <= 12; i++)
        {
            if (i % 2 == 0)
                continue; // Skip even bikes
            Console.WriteLine($"Assisting with Vehicle {i}");
        }

        // Methods, Parameters, and Returning from Methods
        double discountedTotalRevenue = CalculateDiscountedTotal(totalRevenue, 0.1);
        Console.WriteLine($"Discounted Total Revenue: ${discountedTotalRevenue}");
    }

    // Method with parameters and return statement
    static double CalculateDiscountedTotal(double total, double discountRate)
    {
        return total - (total * discountRate);
    }
}

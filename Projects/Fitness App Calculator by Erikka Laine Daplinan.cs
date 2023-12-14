using System;

class CurlsAndCrunches
{
    static void Main()
    {

        Console.WriteLine("Sweat is Fat Crying!");

        string userName;
        int age;
        double weight, height;

        Console.Write("Enter your name: ");
        userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your weight (in kg): ");
        weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height (in meters): ");
        height = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height);

        Console.WriteLine("Hello, " + userName + "!");
        Console.WriteLine($"Age: {age}, Weight: {weight}kg, Height: {height}m");

        Console.WriteLine("\nUpdating user information based on hypothetical scenarios:");

        // Hypothetical scenario 1: Weight loss
        weight -= 2.5;
        Console.WriteLine($"After losing 2.5kg: Weight = {weight}kg");

        // Hypothetical scenario 2: Birthday
        age++;
        Console.WriteLine($"After celebrating a birthday: Age = {age}");

        string additionalInfo = "Thank you for using Curls And Crunches!\n\n" +
            "Here are some tips for maintaining a healthy lifestyle:\n" +
            "\t- Eat a balanced diet with plenty of fruits and vegetables.\n" +
            "\t- Stay hydrated by drinking enough water.\n" +
            "\t- Get regular exercise to keep your body active.\n" +
            "\t- Ensure you get enough quality sleep for recovery.\n" +
            "\t- Consult with a healthcare professional for personalized advice.";

        Console.WriteLine($"\nAdditional Information:\n{additionalInfo}");

        if (bmi < 18.5)
        {
            Console.WriteLine("BMI Category: Underweight");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("BMI Category: Normal Weight");
        }
        else
        {
            Console.WriteLine("BMI Category: Overweight");
        }

        bool isAdult = age >= 18;
        bool isHealthyWeight = bmi >= 18.5 && bmi < 24.9;

        string adultMessage = isAdult ? "You are an adult." : "You are not an adult.";

        switch (age)
        {
            case 18:
                Console.WriteLine("Now that you're 18, you're responsible for yourself!");
                break;
            case 21:
                Console.WriteLine("Happy 21st birthday!");
                break;
            default:
                Console.WriteLine("No special message for this age.");
                break;
        }

        Console.WriteLine("Counting from 1 to 5:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        int counter = 0;
        while (counter < 5)
        {
            counter++;
            if (counter == 3)
                continue;

            Console.WriteLine($"While loop iteration: {counter}");

            if (counter == 4)
                break;
        }


        double calculatedBmi = CalculateBMI(weight, height);
        Console.WriteLine($"Calculated BMI from method: {calculatedBmi}");

        Console.WriteLine(adultMessage);
    }

    static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }
}
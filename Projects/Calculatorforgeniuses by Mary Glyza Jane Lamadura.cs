using System;
using System.Xml.Linq;

namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("-------------------------------------------------\n \nWELCOME TO MY CALCULATOR APP for geniuses\n \n-------------------------------------------------");

                Console.WriteLine("Enter Number");
                Console.WriteLine("");
                Console.Write("Number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Enter an operator ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.WriteLine("");
                Console.Write("Enter an operator: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Added" + "Information: ");
                Console.WriteLine("-------------------------------------------------\n Greater than (>) & Less than Calcutor (<) \n-------------------------------------------------");

                string isAdult = num2 < num1 ? "is greater than" : "is less than";

                if (num1 > num2 && num2 < num1)
                {
                    Console.WriteLine($"The Equation: {num1} > {num2} ");
                    Console.WriteLine($" {num1} {isAdult} {num2} ");
                    Console.WriteLine("");
                }
                else if (num1 < num2 && num2 > num1)
                {
                    Console.WriteLine($"The Equation: {num1} < {num2} ");
                    Console.WriteLine($" {num1} {isAdult} {num2} ");
                    Console.WriteLine("");

                }
                else
                {
                    Console.WriteLine($"The Equation: {num1} = {num2} ");
                    Console.WriteLine($" {num1} is equal to {num2} ");
                    Console.WriteLine("");
                }
              Console.Write("Would you like to continue? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            for (int i = 1; i <= 1; i++)
            {
                Console.WriteLine("Thank You!!");
            }          
                Console.ReadKey();
        }
    }
}

using System;


class BigstonePowerMeals

{

    static void Main()

    {

        Console.WriteLine("Welcome to Bigstone Power Meals!"); // Basic Concepts (Output)

        

        string mealCategory; // Variables

        double price; // Data Types


        Console.WriteLine("\nPlease enter the category of meal you want to order: "); 

        mealCategory = Console.ReadLine(); // User Input


        switch(mealCategory.ToLower()) // Decision Making (switch Statement)

        {

            case "breakfast":

                Console.WriteLine("Available options:\n- Egg Bite Muffins\n- Sausage Casserole\n- Ranchero Omelet"); 

                price = 5.99; // Assignment Operators

                break;

            case "power meals":

                Console.WriteLine("Available options:\n- Chicken Rajas\n- Turkey Fried Rice\n- Baja Fish Bowl");

                price = 10.99;

                break;

            case "low-carb meals":

                Console.WriteLine("Available options:\n- Chicken Pibil\n- Thai Steak\n- Roasted Chicken Salad");

                price = 8.99;

                break;

            default:

                Console.WriteLine("Invalid category entered.");

                return; 

        }


         if(price < 7) 

         {

             Console.WriteLine($"The average price for {mealCategory} is $6.99."); 

         }

         else if(price >=7 && price <11) 

         {

             Console.WriteLine($"The average price for {mealCategory} is $8.99."); 

         }

         else 

         {

             Console.WriteLine($"The average price for {mealCategory} is $10.99.");  

         }


          for(int i=0; i<3; i++)  

          {

              Console.Write($"{i+1}. Would you like to add a drink for an extra $1.50? (yes/no): ");

              string addDrink = Console.ReadLine();

              

              if(addDrink.ToLower() == "yes")  

              {

                  price += 1.50;  

                  break;

              }

              else if(addDrink.ToLower() == "no")  

              {

                  continue; 

              }

              else 

              {

                  Console.WriteLine("Invalid input. Please enter yes or no.");

              }

          }


          double total = CalculateTotal(price); 

          Console.WriteLine($"\nYour total is ${total}.");

          Console.WriteLine("Thank you for choosing Bigstone Power Meals!");

    }


    static double CalculateTotal(double price) 

    {

        double taxRate = 0.12; // Doing Math

        double tax = price * taxRate; 

        double total = price + tax; 

        return total; // Returning from Methods

    }

}


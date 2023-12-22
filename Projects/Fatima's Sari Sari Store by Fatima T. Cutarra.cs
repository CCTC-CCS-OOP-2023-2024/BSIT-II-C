using System;


namespace FatimasSariSariStore

{

    class Program

    {

        static void Main(string[] args)

        {

            // Module 1 - Getting started

            Console.WriteLine("Welcome to Fatima's Sari Sari Store!\n");


            // Variables and Data Types

            double lumpiaPorkPrice = 12.95;

            double bananaTuronPrice = 12.50;

            

            // Doing Math - Total Price Calculation 

            double totalPrice = lumpiaPorkPrice + bananaTuronPrice;


            // Basic Concepts (Output)

            Console.WriteLine($"10 pc Frozen Lumpia Pork: {lumpiaPorkPrice:C}");

            Console.WriteLine($"10 pc Frozen Banana Turon: {bananaTuronPrice:C}");


            

            // Module 2 - Operators and Strings

            

             // User Input

             Console.Write("\nEnter the quantity of Lumpia Pork you want to buy: ");

             int lumpiaQuantity = Convert.ToInt32(Console.ReadLine());


             Console.Write("Enter the quantity of Banana Turon you want to buy: ");

             int turonQuantity = Convert.ToInt32(Console.ReadLine());


             // Arithmetic Operators & Assignment Operators 

             totalPrice = (lumpiaPorkPrice * lumpiaQuantity) + (bananaTuronPrice * turonQuantity);


             

             // Concatenation and Interpolation 

             string receipt = $"Total Price for {lumpiaQuantity} Lumpia Pork and {turonQuantity} Banana Turon is: {totalPrice:C}";

             

             // More on Strings (\n \t @)

             Console.WriteLine($"\nYour receipt is:\n{receipt}\n");


            

           // Module 3 - Decision Making 

           // Comparison Operators & if Statement 

           if (totalPrice > 100)

           {

               Console.WriteLine("\nYou are eligible for a free drink!");

               

               // switch Statement 

               switch (DateTime.Now.DayOfWeek)

               {

                   case DayOfWeek.Monday:

                       Console.WriteLine("You get a Mango Calamansi drink.");

                       break;

                   case DayOfWeek.Tuesday:

                       Console.WriteLine("You get a Strawberry Hibiscus drink.");

                       break;

                   case DayOfWeek.Wednesday:

                       Console.WriteLine("You get a Pear Cucumber drink.");

                       break;

                   default:

                       Console.WriteLine("You get a random drink.");

                       break;

               }

           }

           else

           {

               Console.WriteLine("\nSorry, you are not eligible for a free drink.");

           }


           

          // Module4 - Loops 

          // for Loop 

          Console.WriteLine("\nHere are some other items you might like:");

          string[] items = {"1 Lb Frozen Pork Longanisa", "1 Lb Pork Belly Lechon", "8 oz BBQ, Garlic Mayo, Sweet Chili, Fancy Sauce", "All Purpose Seasoning"};

          for (int i = 0; i < items.Length; i++)

          {

              Console.WriteLine($"{i+1}. {items[i]}");

          }


          // while Loop & break and continue 

          while(true) 

          {

              Console.Write("\nDo you want to add any of these items to your order? (yes/no): ");

              string response = Console.ReadLine();

              

              if(response.ToLower() == "no") 

              {

                  break;  // exit the loop

              }

              else if (response.ToLower() == "yes")

              {

                  Console.Write("Enter the item number: ");

                  int itemNumber = Convert.ToInt32(Console.ReadLine());

                  if (itemNumber < 1 || itemNumber > items.Length)

                  {

                      Console.WriteLine("Invalid item number. Please try again.");

                      continue; // skip the rest of the loop and start over

                  }

                  else

                  {

                      Console.WriteLine($"You added {items[itemNumber-1]} to your order.");

                      // update the total price and receipt here

                  }

              }

              else

              {

                  Console.WriteLine("Invalid response. Please enter yes or no.");

                  continue; // skip the rest of the loop and start over

              }

          }


          // Module 5 - Methods

          // Calling a built-in method from the C# library

          Console.WriteLine($"\nYour order number is: {GenerateOrderNumber()}");


          // Creating and calling a custom method

          PrintThankYouNote();

          

         }


         // A custom method to generate a random order number

         static int GenerateOrderNumber()

         {

             Random random = new Random();

             return random.Next(1000, 10000);

         }


         // A custom method to print a thank you note

         static void PrintThankYouNote()

         {

             Console.WriteLine("\nThank you for your order!");

             Console.WriteLine("We hope you enjoy your food and drinks!");

             Console.WriteLine("Have a nice day!");

         }

     }

}
using System;

namespace mango stand
{
    class largo
  {
    static void Main ()
    {
        Console.WriteLine ("Ernie's mango stand!");
        
        int mango sold = 45;
        
        double pricePerkilo= 60;
        
        string FruitType = Apple mango;
        
       double totalRevenue = mango sold * pricePerKilo;
      
      Console.WriteLine($"Fruit Type: {fruitType}\nFruits Sold:{fruit Sold}\n Price per Kilo: ${pricePerFruits}");
      
     
      string greetings = "Thank you for visiting my mango stand";
      console.WriteLine(greeting);
      
     
      if   (totalCost > 60)
        {
        Console.WriteLine  ("you can add 1 Mango");
        }
     else if  (totalCost >120)
       {
         Console.WriteLine("you can add 1 or 2 mango");
         }
       else 
       {
         Console.WriteLine("Thank you for buying");
       }
       
      
      
       bool is discountAvailable = true;
       
       if (mangoSold > 50 && discountAvailbale);
     
      
      Console.WriteLine("you are qualify for a discount");
      
      Console.Write("Enter your preferred drinks (coke/sprite/shake): ");
            string drinksChoice = Console.ReadLine();
            switch (sauceChoice.ToLower())
            {
                
                case "coke":
                    Console.WriteLine("coke is very refreshing drink.");
                    break;
                case "sprite":
                    Console.WriteLine("sprite is good after eating mango.");
                    break;
                case "shake":
                    Console.WriteLine("shake a little dessert and for refreshments.");
                    break;
                default:
                    Console.WriteLine("Invalid sauce choice. Please select ketchup, mustard, or mayo.");
                    break;
            }
      
      string discountMessage = (totalCost > 60) ? "You've earned a discount!" : "No discount with this order.";
        Console.WriteLine(discountMessage);
        
       
       
        Console.WriteLine("Counting from 1 to 3:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Counting down from 5:");
            int countdown = 7;
            while (countdown > 0)
            {
                Console.WriteLine(countdown);
                countdown--;
            }


            Console.WriteLine("Skipping 2 in a loop:");
            for (int i = 1; i <= 6; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            DisplayOrderSummary(receipt);


            DisplayCustomMessage("Thank you for visiting Ernie's mango stand");


            double change = ProcessPayment(50, totalCost);
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

    using System;

namespace JamFloyd
{

    class Estellore
    {
        static void Main()
        {
          
            Console.WriteLine("Welcome to the Restaurant Menu Program!");

            int tableNumber = 1;
            double totalBill = 0.0;

          
            double taxRate = 0.1; // 10%
            double tipRate = 0.15; // 15%

            Console.WriteLine(); 

            Console.WriteLine("Module 2 - Menu:");

           
            double burgerPrice = 8.99;
            double pizzaPrice = 10.99;
            double saladPrice = 5.99;

            
            Console.WriteLine("Menu: ");
            Console.WriteLine($"1. Burger - ${burgerPrice}");
            Console.WriteLine($"2. Pizza - ${pizzaPrice}");
            Console.WriteLine($"3. Salad - ${saladPrice}");

            Console.Write("Enter the number of the item you want to order: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            double itemPrice = 0.0;
            string itemName = "";

            
            switch (userChoice)
            {
                case 1:
                    itemName = "Burger";
                    itemPrice = burgerPrice;
                    break;
                case 2:
                    itemName = "Pizza";
                    itemPrice = pizzaPrice;
                    break;
                case 3:
                    itemName = "Salad";
                    itemPrice = saladPrice;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid item.");
                    return;
            }

            Console.WriteLine($"You ordered: {itemName}");

            Console.WriteLine(); // Blank line for separation

            
            Console.WriteLine("Module 3 - Additional Options:");

        
            Console.Write("Add extra cheese? (Y/N): ");
            char extraCheeseChoice = Console.ReadLine()[0];
            bool addExtraCheese = (extraCheeseChoice == 'Y' || extraCheeseChoice == 'y');

           
            if (addExtraCheese)
            {
                itemPrice += 1.50;
                Console.WriteLine("Added extra cheese. Additional $1.50.");
            }

            Console.WriteLine(); 

          
            Console.WriteLine("Module 4 - Order Summary:");

            
            Console.WriteLine($"Table: {tableNumber}");
            Console.WriteLine($"Item: {itemName}");
            Console.WriteLine($"Price: ${itemPrice}");

            
            Console.Write("Enter the quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double subtotal = itemPrice * quantity;

            Console.WriteLine($"Subtotal: ${subtotal}");

            
            double tax = 0.0;
            double tip = 0.0;

            int retryCount = 0;
            while (retryCount < 3)
            {
                Console.Write("Do you want to apply a discount? (Y/N): ");
                char discountChoice = Console.ReadLine()[0];

                if (discountChoice == 'Y' || discountChoice == 'y')
                {
                    Console.Write("Enter the discount percentage: ");
                    double discountPercentage = Convert.ToDouble(Console.ReadLine());
                    double discountFactor = 1.0 - (discountPercentage / 100);
                    totalBill = subtotal * discountFactor;
                    break;
                }
                else if (discountChoice == 'N' || discountChoice == 'n')
                {
                    totalBill = subtotal;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter Y or N.");
                    retryCount++;
                }
            }

           
            Console.WriteLine("Calculating tax and tip...");

           
            tax = totalBill * taxRate;

            
            tip = totalBill * tipRate;

            Console.WriteLine($"Tax: ${tax}");
            Console.WriteLine($"Tip: ${tip}");

           
            double grandTotal = totalBill + tax + tip;
            Console.WriteLine($"Total Bill: ${grandTotal}");

            Console.WriteLine(); // Blank line for separation

           
            Console.WriteLine("Module 5 - Thank you!");

            
            DisplayThankYouMessage(tableNumber);

           
            PrintReceipt(itemName, quantity, subtotal, tax, tip, grandTotal);

           
            double discountAmount = CalculateDiscount(subtotal, 10); // Assuming a 10% discount
            Console.WriteLine($"Discount applied: ${discountAmount}");
        }

        
        static void DisplayThankYouMessage(int tableNumber)
        {
            Console.WriteLine($"Thank you for dining with us at Table {tableNumber}!");
        }

       
        static void PrintReceipt(string itemName, int quantity, double subtotal, double tax, double tip, double grandTotal)
        {
            Console.WriteLine("Receipt:");
            Console.WriteLine($"Item: {itemName}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Tax: ${tax}");
            Console.WriteLine($"Tip: ${tip}");
            Console.WriteLine($"Grand Total: ${grandTotal}");
        }

       
        static double CalculateDiscount(double amount, double discountPercentage)
        {
            double discountAmount = amount * (discountPercentage / 100);
            return discountAmount;
        }
    }
}

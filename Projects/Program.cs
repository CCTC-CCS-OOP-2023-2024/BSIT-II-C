using System;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 50;
            int guess;
            int number;
            int guesses;
            int response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    //inserted code for tenary operator
                    int name = 1;
                    string header = name < 0 ? "Goodbye" : "Welcome to GUESS THE NUMBER game\n";
                    Console.WriteLine(header);

                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("\nGuess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is to high!\n");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"{guess} is to low!\n");
                    }
                    guesses++;
                }

                Console.WriteLine("\nYOU WIN!");
                Console.WriteLine($"Number: {number}");
                Console.WriteLine($"Guesses: {guesses}");

                //inserted line for switch
                for (int i = 1; i <= 1; i++)
                {
                    Console.WriteLine("\nWould you like to play again?\n1.Yes\n2.No\nEnter choice: ");
                }
                /*Console.WriteLine("\nWould you like to play again?\n1.Yes\n2.No\nEnter choice: ");*/
                response = Convert.ToInt32(Console.ReadLine());

                switch (response)
                {
                    case 1:
                        playAgain = true;
                        continue;

                    case 2:
                        playAgain = false;
                        Console.WriteLine("Thanks for playing!....");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}

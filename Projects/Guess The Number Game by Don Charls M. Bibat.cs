using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Correct = false;
            int minusscore = 2;
            int score = 100;
            Random random = new Random();

            int rnum = random.Next(1, 26);

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-\t\t\t\t\t\t\t\t\t\t\t      -");
            Console.WriteLine("-                            WELCOME TO GUESS THE NUMBER GAME!                                -");
            Console.WriteLine("-\t\t\t\t\t\t\t\t\t\t\t      -");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-A number between 1 to 25 will be generated. If you guess the correct number, you win!        -");
            Console.WriteLine("-\t\t\t\t\t\t\t\t\t\t\t      -");
            Console.WriteLine("-The faster you guess the correct number, the higher your score.\t\t\t      -\n-Do you want to play?\t\t\t\t\t\t\t\t\t      -");
            Console.WriteLine("-\t\t\t\t\t\t\t\t\t\t\t      -");
            Console.WriteLine("- type (y) for YES or type (n) for NO                                                         -");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            char choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'y' || choice == 'Y')
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("-Please enter your name:                                                                      -");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                string name = Console.ReadLine();

                while (!Correct)
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                    Console.WriteLine("-Please enter your guess:                                                                     -");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > rnum)
                    {
                        score = score - minusscore;
                        Console.WriteLine("-Your guess is to high!                                                                       -");
                    }

                    else if (guess < rnum)
                    {
                        score = score - minusscore;
                        Console.WriteLine("-Your guess is to low!                                                                        -");
                    }

                    else
                    {
                        Console.WriteLine("-Correct!                                                                                     -");
                        Correct = true;
                    }
                }



                Console.WriteLine("-Congratulations, you have won the game!                                                      -");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine(" Name: " + name + "");
                Console.WriteLine("-Score: " + score + "/100                                                                    -");
                Console.WriteLine("-\t\t\t\t\t\t\t\t\t\t\t      -");

            }

            else if (choice == 'n' || choice == 'N')
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("Thank you for your time, please come again!\t\t\t\t\t\t      -");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
            }

            else
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("Oops! I think you input wrong letter. Please try again\t\t\t\t\t      -");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
            }

        }
    }
}
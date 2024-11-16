using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Guess the Number Game";
            Console.WriteLine("Welcome To The Number Guessing Game! Where you have 3 attempts to guess the Random Number.");

            int highNum;
            int guess1;
            int guess2;
            int guess3;
            int attempts = 3;

            Console.Write("How high do you want the guessing number to be? ");
            highNum = Convert.ToInt32(Console.ReadLine());

            if (highNum < 15) {
                Console.WriteLine("You can't have a number lower than 15.");
                return;
            }

            Random randomNum = new Random();
            int correctNumber = randomNum.Next(0, highNum); 

            while (attempts > 0)
            {
                Console.Write("Please enter your first guess: ");
                guess1 = Convert.ToInt32(Console.ReadLine());

                if (guess1 == correctNumber) {
                    Console.WriteLine($"You won! {correctNumber} was the correct number!");
                    return;
                }
                else {
                    Console.WriteLine($"Sorry, {guess1} is incorrect. Try again!\n");
                    attempts--;
                }

                Console.Write("Please enter your second guess: ");
                guess2 = Convert.ToInt32(Console.ReadLine());

                if (guess2 == correctNumber) {
                    Console.Write($"You won! {correctNumber} was the correct number.");
                } else {
                    Console.Write($"Sorry {guess2} was not correct, please try again.");
                    attempts--;
                }
                Console.Write("Please enter your third and last guess: ");
                guess3 = Convert.ToInt32(Console.ReadLine()); 

                if (guess3 == correctNumber) {
                    Console.Write($"You Won! {correctNumber} was the correct number.");
                } else {
                    attempts--;
                }
            }

            while (attempts == 0) {
                Console.WriteLine($"Sorry, you've run out of attempts. The correct number was {correctNumber}.");
                return;
            }
            Console.ReadKey();
        } 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberguess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            bool play = true;
            Random random = new Random();
            
            int guess ;
            int guesses=1 ;
            Console.WriteLine("Number Guessing Game!");
           

            while (play) {
                int randNum = random.Next(1, 101);
                guess =0 ;
                Console.ResetColor();
                while (guess != randNum) {
                    Console.WriteLine("Guess a number between 1 - 100");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == randNum)
                {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Your Guess is Correct!");
                        Console.WriteLine("Your guessed: " + guesses + " times");

                    }
                else if (guess > randNum)
                {
                     

                        Console.WriteLine("Your guess is too high");
                        Console.WriteLine("Your guessed: " + guesses + " times");


                    }
                else if (guess < randNum)
                {
                        Console.WriteLine("Your guess is too low ");
                        Console.WriteLine("Your guessed: " + guesses+ " times") ;
                    
                }
                else { Console.WriteLine("Invalid input"); }
                  guesses++;

            }
               
                Console.WriteLine("Play Again ? (Y / N)");
                string agn = Console.ReadLine();
                agn = agn.ToUpper();
                if (agn == "Y")
                {
                    play = true;
                    guesses = 1;

                }
                else { play = !true; }

            }
          

            Console.ReadKey();

        }
    }
}

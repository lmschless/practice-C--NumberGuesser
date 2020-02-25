using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get info

            GreetUser(); // Ask for users name and greet

            //int correctNumber = 7;
            while (true) { 
            // Create a new random object
            Random random = new Random();

            // Init correct number
            int correctNumber = random.Next(1, 10);

            // Init guess var
            int guess = 0;
            
            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while (guess != correctNumber)
            {
                // Get users input
                string input = Console.ReadLine();

                // Make sure it's a number
                if (!int.TryParse(input, out guess))
                {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                    continue;
                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to corect number
                if (guess != correctNumber)
                {
                    
                     PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");


                // Ask to play again
                Console.WriteLine("Would you like to play again? [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Luke Schlessinger";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Change color back
            Console.ResetColor();
        }
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // Write user input
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Output success message
            Console.ForegroundColor = color;

            // Tell user it's the right number
            Console.WriteLine(message);

            // Change color back
            Console.ResetColor();
        }
    }
}
using System;

namespace GuessingGame1._0
{
    class Program
    {
        static void Main()
        {

            // Set console window to reasonable size
            Console.SetWindowSize(70, 25);

            // Functions below main loop
            GetAppInfo();

            GreetUser();

            while (true)
            {
                // Set number to guess - non random (for testing)
                //int correctNumber = 7;

                // Set number to guess - true random

                // Create a new random object
                Random random = new Random();

                //Init true random number
                int correctNumber = random.Next(1, 11);

                // Init guess var
                int guess = 0;

                // Ask user for number input
                Console.WriteLine("Please pick a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure user input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintConsoleColor(ConsoleColor.Red, "Please enter an actual number.");
                        
                        continue;
                    }

                    // Cast to int and assign to 'guess' variable
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Output incorrect guess message
                        PrintConsoleColor(ConsoleColor.Red, "Sorry, that's the wrong Number, please pick another number.");
                    }
                }

                // Output correct guess message
                PrintConsoleColor(ConsoleColor.Yellow, "Awesome, that's the CORRECT number!!!");

                //Ask user if they want to play again
                Console.WriteLine("Would you like to play the number guessing game again? [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    //TODO - add counter for stats

                    Console.Clear();

                    // Game info always on top (psuedo-hud)
                    GetAppInfo();

                    continue;
                }
                else if (answer == "N")
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
            // Set app variables
            string appName = "Guessing Game";
            string appVersion = "1.0";
            string appAuthor = "Jason Thomas";

            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write app intro
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Change console window title
            Console.Title = string.Format("{0}'s Number Guessing Game", appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask user's name
            Console.WriteLine("What is you name?");

            // Get user's input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintConsoleColor(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;

            //Tell user to select number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}

//TODO - Prompt user to set range, low to high, for random number
//TODO - Keep stats for individual session, display in psuedo onscreen display at tope of screen
//TODO - stats for overall game sessions, file I/O (possibly encrypted?)
//TODO - Provide user with hints (hotter, colder) based on math performed on guess vs correct number.
//          ^ IE, guess more than 25% of range away from correct number == "very cold" message.
//          ^ Guess within 10% of correct number == "very hot" message.
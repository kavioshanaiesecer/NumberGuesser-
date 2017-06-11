using System;

// Namespace
namespace NumberGusser
{
    // Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            /* string name = "Kaveendra";
             int age = 35;

             // START HERE
             //Console.WriteLine("Hello I'm "+name+" ,my age is "+age);
             Console.WriteLine("{0} is {1}", name, age);
             Console.ReadLine();
             */

            // Run GetAppInfo function
            GetAppInfo();

            // Ask for User
            GreetUser();

            while (true)
            {

                // Create new Random object
                Random random = new Random();

                // Init Correct Number
                int correctNumber = random.Next(1, 10);

                // Init Correct Number
                //int correctNumber = 7;

                // Init Guess Var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 & 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get the user input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print Error Message 
                        PrintColorMessage(ConsoleColor.Red, "Please user in actual number");

                        // Keep Going
                        continue;
                    }

                    // Cast to int and put to guess var
                    guess = Int32.Parse(input);

                    //Match guess to Wrong number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number, Please Try Again!!!");
                    }
                }

                // Print Correct Message Color
                PrintColorMessage(ConsoleColor.Yellow, "YOU ARE CORRECT!!! YOU GUESSED IT");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get the answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
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

        // Get and Display app info
        static void GetAppInfo()
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthour = "Oshan";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Wrtie out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthour);

            // Reset Text Color
            Console.ResetColor();
        }

        // Ask users name and clean
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("Enter Your Name? ");

            // Get the user input
            string inputName = Console.ReadLine();

            // Value Displaying in place holder
            Console.WriteLine("Hello {0}, Let's Play a game!!!", inputName);
        }

        // Print Color Message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user that it's not a number
            Console.WriteLine(message);

            // Reset Text Color
            Console.ResetColor();
        }
    }
}

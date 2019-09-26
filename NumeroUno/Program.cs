using System;

namespace NumeroUno
{
    //Main Class
    class Program
    {
        static void Main(string[] args)
        // static void GetInfo()
        {
            //string name = "Johnson Guedes";
            //int age = 35;

            // Console.WriteLine(name + " is " + 35 );
            //Console.WriteLine("{0} is {1}", name, age);

            //Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string AppAuthor = "Johnson";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            // App info
            Console.WriteLine("{0}: Version{1} by {2}", appName, appVersion, AppAuthor);

            //Reset text color
            Console.ResetColor();

            //Ask user name
            Console.WriteLine("What is your name");

            //Get user name
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Lets play", inputName);

            while (true)
            {
                //Init correct number
                //int correctNumber = 7;

                //Create a new random number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;
                // Ask user a number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {  // Get user input
                    string input = Console.ReadLine();
                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;
                        //Tell user its not a number
                        Console.WriteLine("Please enter an actual number");
                        //Reset color
                        Console.ResetColor();
                        //Keep going
                        continue;
                    }
                    //Cast to int and put in guess
                    guess = Int32.Parse(input);
                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;
                        //Tell user wrong number
                        Console.WriteLine("Wrong number. Please Try again");
                        //Reset color
                        Console.ResetColor();


                    }
                }
                ///Ouput success message
                //Change text color
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Tell user right number
                Console.WriteLine("Hey! You have guesses the RIGHT number!!!!");
                //Reset color
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
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
    }
}

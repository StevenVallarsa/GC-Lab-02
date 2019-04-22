using System;

namespace StringApplication
{

    class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("Welcome to Grand Circus' Room Detail Generator\n");
            bool isTrue = true;

            while (isTrue)
            {

                // Get user input
                Console.Write("\nEnter Length: ");
                double length = CheckValidity();
                Console.Write("Enter Width: ");
                double width = CheckValidity();
                Console.Write("Enter Height: ");
                double height = CheckValidity();

                // Calculate results
                double area = length * width;
                double perimiter = (length + width) * 2;
                double volume = perimiter * height;

                //Print results
                Console.WriteLine("\nArea: {0}",area);
                Console.WriteLine("Perimiter: {0}", perimiter);
                Console.WriteLine("Volume: {0}", volume);

                // Ask user if they want to do this again
                // - Takes first letter of response: if not
                //   "y" or "n" will ask user to try again.
                while (true)
                {
                    Console.Write("\nContinue? (y/n) ");
                    string answer = Console.ReadLine().ToLower();

                    if (answer[0] == 'n')
                    {
                        isTrue = false;
                        break;
                    }
                    else if (answer[0] == 'y')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Oops. That's not a valid input. Please try again.");
                    }
                }
            }
            Console.WriteLine("Goodbye!");

        }

        // Method to check validity of user input.
        static double CheckValidity()
        {

            // Keep asking for user input until valid number is returned.
            while (true)
            {

                string userInput = Console.ReadLine();

                try
                {
                    double output = Convert.ToDouble(userInput);
                    return output;
                }
                catch (Exception)
                {
                    Console.Write("Oops. That not a valid input. Please try again: ");
                }
            }
        }

    }

}
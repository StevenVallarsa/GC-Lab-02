using System;

namespace StringApplication
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Welcome to Grand Circus' Room Detail Generator");
            bool isTrue = true;

            while (isTrue)
            {
                Console.Write("\nEnter Length: ");
                double length = CheckValidity();

                Console.Write("Enter Width: ");
                double width = CheckValidity();

                double area = length * width;
                double perimiter = (length + width) * 2;

                Console.WriteLine("Area: {0}",area);
                Console.WriteLine("Perimiter: {0}", perimiter);

                Console.Write("\nContinue? (y/n) ");
                string answer = Console.ReadLine().ToLower();

                if (answer != "y")
                {
                    isTrue = false;
                }
            }

        }

        static double CheckValidity()
        {

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
                    Console.WriteLine("Oops. That wasn't a valid input. Please try again: ");
                }
            }
        }

    }

}
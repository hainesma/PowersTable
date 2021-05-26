using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {

            bool goOn = true;
            while (goOn == true)
            {

                int number = GetInteger();

                {

                    // Powers Table
                    Console.WriteLine("Number \t \t Squared \t Cubed");
                    Console.WriteLine("====== \t \t ====== \t ======");

                    for (int i = 1; i <= number; i++)
                    {
                        Console.WriteLine($"{i} \t \t {i * i} \t \t {i * i * i}");
                    }
                }

                goOn = GetContinue();
            }
        }

        public static int GetInteger()
        {
            Console.WriteLine("Please enter a natural number.");
            string input = Console.ReadLine();
            int parsed = int.Parse(input);
            ValidateInteger(parsed);
            return parsed;
        }

        public static int ValidateInteger(int number)
        {
            if (number < 1)
            {
                Console.WriteLine("Your input is not suitable.");
                number = GetInteger();
                return ValidateInteger(number);
            }
            else
            {
                return number;
            }
        }

        public static bool GetContinue()
        {
            Console.WriteLine("Would you like to continue? (Y/N)");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that. Please try again.");
                return GetContinue();
            }
        }
    }
}

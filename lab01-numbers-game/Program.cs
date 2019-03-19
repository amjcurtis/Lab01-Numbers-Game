using System;

namespace lab01_numbers_game
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        static void StartSequence()
        {
            Console.WriteLine("Let's do some math!");
            Console.WriteLine("Please enter an integer greater than zero.");

            // Take in user's initial number choice as string
            string firstUserNumberAsString = Console.ReadLine(); // TODO handle invalid format exception in case user enters invalid char or number (non-int, neg)

            // Convert user's initial number choice to int
            int firstUserNumberAsInt = Convert.ToInt32(firstUserNumberAsString);

            // Declare array of length of user's initial number
            int[] userArray = new int[firstUserNumberAsInt];

            // Loop to get user to enter a number for each element of array
            for (int i = 1; i <= firstUserNumberAsInt; i++)
            {
                Console.WriteLine($"Please enter number {i} of {firstUserNumberAsInt}");
                // Add current number to user's array (using Populate method?)

            }
        }
    }
}

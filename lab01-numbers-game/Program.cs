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
            string firstUserNumberAsString = Console.ReadLine(); 
            
            // TODO handle invalid format exception in case user enters invalid char or number (non-int, neg)


            // Convert user's initial number choice to int
            int firstUserNumberAsInt = Convert.ToInt32(firstUserNumberAsString);

            // Declare array of length of user's initial number
            int[] userArray = new int[firstUserNumberAsInt];

            // Store populated int array as variable
            int[] populatedArray = Populate(userArray);

        }

        static int[] Populate(int[] intArray)
        {
            // Create empty string array to store user's input
            string[] userStringArray = new string[intArray.Length];

            // Loop to get user to enter a number for each element of array
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"Please enter number {i + 1} of {intArray.Length}");
                string userNumAsString = Console.ReadLine(); // TODO handle invalid format of user input

                // Add user input to current index of string array
                userStringArray[i] = userNumAsString;
            }
        }

        static int GetSum(int[] intArray)
        {

        }
    }
}

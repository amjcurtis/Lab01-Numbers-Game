using System;

namespace lab01_numbers_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Numbers Game!");
            Console.WriteLine(" ");

            try
            {
                StartSequence();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, something went wrong.");
                Console.WriteLine($"e.Message: {e.Message}");
            }
            finally
            {
                Console.WriteLine("The program is finished.");
            }

            Console.ReadLine();
        }

        static void StartSequence()
        {
            Console.WriteLine("Let's do some math!");
            Console.WriteLine("Please enter an integer greater than zero.");

            // Take in user's initial number choice as string
            string firstUserNumberAsString = Console.ReadLine();
            Console.WriteLine(" ");

            // TODO Handle invalid format exception in case user enters invalid char or number (non-int, neg)
                // Out message to console

            // TODO Handle OverFlow exception
                // Output message to console

            // Convert user's initial number choice to int
            int firstUserNumberAsInt = Convert.ToInt32(firstUserNumberAsString);

            // Declare array of length of user's initial number
            int[] userArray = new int[firstUserNumberAsInt];

            // Store populated int array as variable
            int[] populatedArray = Populate(userArray);

            // Store sum of numbers in array of numbers chosen by user
            int sumOfArray = GetSum(populatedArray);

            // Store product of sum of array elements multiplied by number at array index picked by user
            int product = GetProduct(populatedArray, sumOfArray);

            // Store quotient of product divided by a divisor input by user
            decimal quotient = GetQuotient(product);

            // TODO Output results of all the math operations to the console
            Console.WriteLine($"The length of your array is: {firstUserNumberAsString}.");
            Console.WriteLine($"The numbers in the array are: " + "[{0}]", string.Join(",", populatedArray)); // Got idea for this way of printing contents of array on Stack Overflow
            Console.WriteLine($"The sum of the array is: {sumOfArray}.");
            int extractedFactor = product / sumOfArray;
            Console.WriteLine($"{sumOfArray} * {extractedFactor} = {product}");
            decimal extractedDivisor = Convert.ToDecimal(product) / quotient;
            Console.WriteLine($"{product} / {extractedDivisor} = {quotient}");
        }

        static int[] Populate(int[] intArray)
        {
            // Create empty int array to store user's input
            int[] userIntArray = new int[intArray.Length];

            // Loop to get user to enter a number for each element of array
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"Please enter number {i + 1} of {intArray.Length}.");
                string userNumAsString = Console.ReadLine(); // TODO handle invalid format of user input

                int userNumAsInt = Convert.ToInt32(userNumAsString);

                // Add user input to current index of string array
                userIntArray[i] = userNumAsInt;
            }
            return userIntArray;
        }

        static int GetSum(int[] intArray)
        {
            // Set counter
            int sum = 0;

            // Sum elements of array
            foreach (int element in intArray)
            {
                sum += element;
            }

            // TODO Add ability to throw custom exception is sum < 20
            // Error message should be: "$Value of {sum} is too low"

            Console.WriteLine($"The sum of the numbers you entered is {sum}.");
            return sum;
        }

        static int GetProduct(int[] intArray, int sum)
        {
            Console.WriteLine($"Please pick a random number between 1 and {intArray.Length}.");

            // Store user's random number as variable
            string userPickAsString = Console.ReadLine();

            // Convert user pick to int
            int userPickAsInt = Convert.ToInt32(userPickAsString); // TODO handle invalid format of user input

            // TODO Handle IndexOutOfRange exception
                // Output message to console
                // Throw exception back down to Main


            // Multiply sum argument by array element at index corresponding to user's random number
            int product = intArray[userPickAsInt] * sum;

            return product;
        }

        static decimal GetQuotient(int product)
        {
            Console.WriteLine($"Please enter a number to divide your product {product} by.");

            // Store user's selected number as string
            string divisorAsString = Console.ReadLine();

            // TODO Handler DivideByZero exception
                // Output message to console
                // Don't throw it back to Main
                // Return 0 if catch gets called

            // Convert user's number to decimal
            decimal divisorAsDecimal = Convert.ToDecimal(divisorAsString);
            Console.WriteLine($"divisorAsDecimal is: {divisorAsDecimal}");

            // Convert product argument from int to decimal
            decimal productAsDecimal = Convert.ToDecimal(product);

            // Calculate and store quotient as decimalS
            decimal quotient = Decimal.Divide(productAsDecimal, divisorAsDecimal);

            return quotient;
        }
    }
}

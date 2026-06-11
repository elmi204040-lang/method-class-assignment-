using System;

namespace MethodAssignment
{
    // This class contains a method that performs a simple math operation
    class MathOperations
    {
        // This method takes two integers as parameters
        // It performs a math operation (multiplying the first integer by 2)
        // and displays the second integer to the screen
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer
            int result = num1 * 2;

            // Display what operation was done
            Console.WriteLine($"First number: {num1}");
            Console.WriteLine($"After multiplying by 2, result is: {result}");

            // Display the second integer to the screen
            Console.WriteLine($"Second number displayed as-is: {num2}");
        }
    }
}

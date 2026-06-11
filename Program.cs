using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display header for clarity
            Console.WriteLine("===== Method Assignment =====\n");

            // Create (instantiate) an object of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the PerformOperation method with two integers passed directly
            // The method will perform a math operation on the first integer and display the second
            mathOps.PerformOperation(10, 5);

            Console.WriteLine(); // Blank line for readability

            // Call the same method again, this time specifying parameter names
            // This helps demonstrate how to call a method by naming arguments explicitly
            mathOps.PerformOperation(num1: 20, num2: 7);

            // Display a completion message
            Console.WriteLine("\nProgram finished. Press any key to exit...");
            Console.ReadKey();
        }
    }
}

using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the sides of the triangle
            Console.WriteLine("Enter the length of the first side of the triangle:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the length of the second side of the triangle:");
            string input2 = Console.ReadLine();

            Console.WriteLine("Enter the length of the third side of the triangle:");
            string input3 = Console.ReadLine();

            // Convert the inputs to integers
            if (int.TryParse(input1, out int side1) &&
                int.TryParse(input2, out int side2) &&
                int.TryParse(input3, out int side3))
            {
                // Determine the type of the triangle
                string triangleType = DetermineTriangleType(side1, side2, side3);

                // Display the type of the triangle
                Console.WriteLine($"The triangle is: {triangleType}");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter valid numerical values for the sides of the triangle.");
            }
        }

        static string DetermineTriangleType(int side1, int side2, int side3)
        {
            // Check for equilateral triangle
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            // Check for isosceles triangle
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isosceles";
            }
            // Otherwise, it's a scalene triangle
            else
            {
                return "Scalene";
            }
        }
    }
}

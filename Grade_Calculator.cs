using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a numerical grade
            Console.WriteLine("Enter a numerical grade between 0 and 100:");

            // Read the user input
            string input = Console.ReadLine();

            // Convert the input to an integer
            if (int.TryParse(input, out int grade))
            {
                // Determine the letter grade based on the numerical grade
                string letterGrade = CalculateLetterGrade(grade);

                // Display the letter grade
                Console.WriteLine($"The letter grade is: {letterGrade}");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
            }
        }

        static string CalculateLetterGrade(int grade)
        {
            // Determine the letter grade based on the numerical grade
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}

using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.WriteLine("Enter your age:");

            // Read the user input
            string input = Console.ReadLine();

            // Convert the input to an integer
            if (int.TryParse(input, out int age))
            {
                // Determine the ticket price based on the age
                int ticketPrice = CalculateTicketPrice(age);

                // Display the ticket price
                Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }

        static int CalculateTicketPrice(int age)
        {
            // Determine the ticket price based on the age
            if (age <= 12 || age >= 65)
            {
                return 7;
            }
            else
            {
                return 10;
            }
        }
    }
}

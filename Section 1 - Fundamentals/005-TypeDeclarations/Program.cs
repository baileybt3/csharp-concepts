/*
 * - Declaring Different Types
 * - Brandon B
 * - 07/25/2026
 */
namespace _005_TypeDeclarations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Different Type Declarations
            Console.WriteLine("--- Different Variable Declarations ---");
            int count = 10;
            double total = 5.25;
            char grade = 'A';
            string message = "You got a good grade!";
            bool sent = false;

            // Output Values
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Message: " + message);
            Console.WriteLine("Sent: " + sent);

            // Declaring Constants
            Console.WriteLine("\n--- Declaring Constants ---");
            const int MAX_QUANTITY = 50;
            const string COMPANY_NAME = "Coding Inc.";

            Console.WriteLine("Maximum Quantity: " + MAX_QUANTITY);
            Console.WriteLine("Company Name: " + COMPANY_NAME);

            // Type Casting
            Console.WriteLine("\n--- Type Casting ---");
            double price = 9.99;
            int intPrice = (int)price;

            // Output 
            Console.WriteLine("Price w/ Cents: " + price);
            Console.WriteLine("Price w/o Cents: " + intPrice);
        }
    }
}

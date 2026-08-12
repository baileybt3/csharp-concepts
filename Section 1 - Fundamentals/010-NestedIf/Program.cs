/*
 * Nested If Statements
 * Brandon Bailey
 * 07/29/2026
 */
namespace _010_NestedIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int age = 20;
            bool validId = true;
            int height = 63;

            string output = "";

            // Can this person go to a bar?
            if (height > 45)
            {
                if (validId)
                {
                    if (age >= 21)
                    {
                        output = "You can go in and drink.";
                    }
                    else
                    {
                        output = "You can go in but cannot drink.";
                    }
                }
                else
                {
                    output = "Sorry, you need a valid ID.";
                }
            }
            else
            {
                output = "Sorry, you are not tall enough.";
            }

            Console.WriteLine(output);
        }
    }
}

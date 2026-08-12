/*
 * While Loops
 * 08/05/2026
 * Brandon Bailey
 */
namespace _013_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool choice = true;
            Random randomNum = new Random();

            while(choice == true)
            {
                Console.WriteLine("Generate a new number? (Enter Y or N)");
                string input = Console.ReadLine().ToLower();

                if(input == "y")
                {
                    int randNum = randomNum.Next();
                    Console.WriteLine("Your Number is: " + randNum);
                    
                }
                else if(input == "n")
                {
                    Console.WriteLine("Goodbye");
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter a valid input: ");
                }
                

            }
        }
    }
}

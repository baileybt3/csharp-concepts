/*
 * 020 - Accessing Elements in Arrays
 * Brandon Bailey   
 * 08/22/2026
 */
namespace _020_AccessimgElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            string[] word = { "heimer", "jhin" };

            bool[] boolean = { true, false };

            double[] decimals = { .3, .5, 1.0, 1.25, 1.5 };

            Console.WriteLine($"The second element of the numbers array is: {numbers[1]}");

            Console.WriteLine($"Index 0 of string array: {word[0]}");

            Console.WriteLine($"Index 1 of boolean array: {boolean[1]}");

            Console.WriteLine($"Index 3 of double array: {decimals[3]}");

            Console.WriteLine("Understand? (y/n) ");

            string userInput = Console.ReadLine();

            if(userInput == "y")
            {
                Console.WriteLine("Good! You understand how to access elements in an array. Goodbye!");
            } 

            if(userInput == "n")
            {
                Console.WriteLine("No worries! Let's review the code again. Goodbye!");
            }
            



        }
    }
}

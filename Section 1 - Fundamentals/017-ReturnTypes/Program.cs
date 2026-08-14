/*
 * 017-Return Types
 * Brandon Bailey
 * 08/13/2026
 */
namespace _017_ReturnTypes
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string and I will count the letters");
            string userInput = Console.ReadLine();
            Console.WriteLine("The number of characters in your string is: " + CountCharacters(userInput) + "\n");

            Console.WriteLine("The number of spaces in your string is: " + CountSpaces(userInput));
        }

        public static string CountCharacters(string input)
        {
            int count = 0;
            for(int i = 0; i < input.Length; i++)
            {
                count++;
            }
            return count.ToString();
        }

        public static int CountSpaces(string input)
        {
            int count = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }

    }
}

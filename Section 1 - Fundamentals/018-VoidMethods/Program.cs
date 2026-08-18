/*
 * 018 - Void Methods
 * Brandon Bailey
 * 08/17/2026
 */
namespace _018_VoidMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a comma seperated input!");

            string userInput = Console.ReadLine();

            countWords(userInput);

        }

        public static void countWords(string text)
        {
            string[] words = text.Split(',', StringSplitOptions.TrimEntries);

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}

/*
 * 024-String Methods
 * Brandon Bailey
 * 08/26/2026
 */
namespace _024_StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            string input = Console.ReadLine();
            StringMethods(input);
        }

        public static void StringMethods(string input)
        {
            // Display the length of the string
            Console.WriteLine($"Length of the string: {input.Length}");

            // Convert to uppercase
            Console.WriteLine($"Uppercase: {input.ToUpper()}");

            // Convert to lowercase
            Console.WriteLine($"Lowercase: {input.ToLower()}");

            // Trim whitespace
            Console.WriteLine($"Trimmed: '{input.Trim()}'");

            // Check if the string contains a specific substring
            Console.WriteLine($"Contains 'test': {input.Contains("test")}");

            // Replace a substring with another substring
            Console.WriteLine($"Replace 'a' with 'o': {input.Replace('a', 'o')}");

            // Split the string into an array of substrings
            string[] words = input.Split(' ');
            Console.WriteLine("Words in the string:");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}

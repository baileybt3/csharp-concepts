/*
 * Declaring Arrays
 * 08/19/2026
 * Brandon Bailey
 */
namespace _019_DeclaringArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] myStrings = new string[3];

            Console.WriteLine("Enter 3 different strings");

            Console.Write("Enter string 1: ");

            myStrings[0] = Console.ReadLine();

            Console.Write("Enter string 2: ");

            myStrings[1] = Console.ReadLine();

            Console.Write("Enter string 3: ");

            myStrings[2] = Console.ReadLine();

            Console.WriteLine("");
            for(int i = 0; i < myStrings.Length; i++)
            {
                Console.WriteLine($"String {i + 1}: {myStrings[i]}");
            }

        }
    }
}

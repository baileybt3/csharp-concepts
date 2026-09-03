/*
 * 09/02/2026
 * 027_ForEachLoop
 * Brandon Bailey
 */
namespace _027_ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a list of words separated by commas:");

            string[] pokemonList = Console.ReadLine().Split(",");

            foreach(string word in pokemonList)
            {
                Console.WriteLine(word);
            }

        }
    }
}

/*
 * Increments and Decrements
 * Brandon B
 * 07/27/2026
 */
namespace _007_IncrementDecrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int postIncrement = 0;
            int preIncrement = 0;
            int postDecrement = 0;
            int preDecrement = 0;

            for (int i = 0; i < 3; i++)
            {
                postIncrement++; // Returns current value, then adds 1

                ++preIncrement; // Adds 1 to variable first, then returns updated value

                postDecrement--; // Returns the current value first, then subtracts 1

                --preDecrement; // Subtracts 1 from the variable first, then returns updated value

                Console.WriteLine("Loop " + i + ": \n");
                Console.WriteLine($"Post Increment = {postIncrement}");
                Console.WriteLine($"Pre Increment = {preIncrement}");
                Console.WriteLine($"Post Decrement = {postDecrement}");
                Console.WriteLine($"Pre Decrement = {preDecrement}\n");
            }


        }
    }
}

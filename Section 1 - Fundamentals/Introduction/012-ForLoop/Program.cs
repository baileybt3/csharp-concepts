/*
 * For Loop
 * 08/04/2026
 * Brandon Bailey
 */
namespace _012_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i = 0; i < 10; i++)
            {
                sum += 1;
                Console.WriteLine(sum);
            }

            Console.WriteLine($"Final Sum: {sum}");
        }
    }
}

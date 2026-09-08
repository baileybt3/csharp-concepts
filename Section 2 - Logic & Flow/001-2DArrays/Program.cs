/*
   0-1-2D Arrays
   Brandon Bailey
   2024-06-10 
*/
namespace _001_2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] numberGrid =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Access one value
            Console.WriteLine($"Value at row 1, column 2: {numberGrid[1, 2]}");

            Console.WriteLine("\nEntire Grid:");
            // Display entire grid w nested loops
            for(int row = 0; row < numberGrid.GetLength(0); row++)
            {
                for (int column = 0; column < numberGrid.GetLength(1); column++)
                {
                    Console.Write(numberGrid[row, column] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

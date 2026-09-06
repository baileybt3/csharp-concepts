/*
 * Number Pyramids
 * Brandon Bailey
 * 09/06/2026
 */
 namespace NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of your pyramid base: ");

            // TryParse input to valid it is a positive integer
            if (!int.TryParse(Console.ReadLine(), out int rowSize) || rowSize <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            // Loop through rows to create the pyramid
            for (int row = 0; row < rowSize; row++)
            {
                int numberOfSpaces = rowSize - row - 1;
                int numberOfStars = 2 * row + 1;

                string spaces = new string(' ', numberOfSpaces);
                string stars = new string('*', numberOfStars);

                Console.WriteLine(spaces + stars);
            }

        }
    }
}

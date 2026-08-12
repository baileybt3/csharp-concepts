/*
 * 015 - Nested Loops
 * Brandon Bailey
 * 08/11/2026
 */
Console.WriteLine("Please enter a width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter a height: ");
int height = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
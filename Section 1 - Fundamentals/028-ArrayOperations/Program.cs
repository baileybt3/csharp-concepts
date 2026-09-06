/*
 * 028-ArrayOperations
 * Brandon Bailey
 * 09/06/2028
 */
namespace _028_ArrayOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string of number seperated by a comma: ");
            string input = Console.ReadLine();
            string[] inputArr = input.Split(',');
            int[] numbers = new int[inputArr.Length];

            for (int i = 0; i < inputArr.Length; i++)
            {
                numbers[i] = int.Parse(inputArr[i]);
            }

            double[] stats = CalculateStats(numbers);

            Console.WriteLine($"Sum: {stats[0]}, Average: {stats[1]}, Min: {stats[2]}, Max: {stats[3]}");
        }

        static double[] CalculateStats(int[] numbers)
        {
            double sum = 0;
            double min = numbers[0];
            double max = numbers[0];
            foreach (int num in numbers)
            {
                sum += num;
                if (num < min) min = num;
                if (num > max) max = num;
            }
            double average = sum / numbers.Length;
            return new double[] { sum, average, min, max };
        }
    }
}

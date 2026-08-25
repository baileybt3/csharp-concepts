/*
 * 023-ReversedArray
 * Brandon Bailey
 * 08/25/2026
 */
using System;
namespace _023_ReversedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an array of numbers: (comma separated) ");
            string input = Console.ReadLine();
            string[] inputArr = input.Split(",");

            // Parse string input into array of ints
            int[] arr = new int[inputArr.Length];
            for(int i = 0; i < inputArr.Length; i++)
            {
                arr[i] = int.Parse(inputArr[i]);
            }

            int[] reversedArray = ReverseArray(arr); // Call ReverseArray method
            Console.WriteLine("Reversed array: " + string.Join(", ", reversedArray));
        }

        public static int[] ReverseArray(int[] arr)
        {
            int[] reversedArray = new int[arr.Length];
            int reverseIndex = 0;

            for(int i = arr.Length - 1; i >= 0; i--)
            {
                reversedArray[reverseIndex] = arr[i];
                reverseIndex++;
            }

            return reversedArray;
        }
    }
}

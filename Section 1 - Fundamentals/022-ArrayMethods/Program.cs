using System;

namespace _022_ArrayMethods
{
    internal class Program
    {

        // <summary> Merge Array Methods </summary>
        public static string[] MergeArrays(string[] array1, string[] array2)
        {
            string[] mergedArray = new string[array1.Length + array2.Length];
            Array.Copy(array1, mergedArray, array1.Length);
            Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);
            return mergedArray;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first array of strings: ");
            string[] userString = Console.ReadLine().Split(' ');

            Console.WriteLine("Enter the second array of strings: ");
            string[] userString2 = Console.ReadLine().Split(' ');

            string[] mergedArray = MergeArrays(userString, userString2);

            Console.Write("Merged Array: ");

            for (int i = 0; i < mergedArray.Length; i++)
            {
                Console.Write($"{mergedArray[i]} ");
            }

        }
    }
}

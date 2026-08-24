using System;

namespace _021_ModifyingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a list of words, seperated by ' ' ");
            string textArray = Console.ReadLine();

            Console.WriteLine("Input the index of the element you want to modify: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the new element: ");
            string newElement = Console.ReadLine();

            string[] array = textArray.Split(' ');
            string[] modifiedArray = ModifyArray(array, index, newElement);

            for(int i = 0; i < modifiedArray.Length; i++)
            {
                Console.Write(modifiedArray[i] + " ");
            }

        }

        public static string[] ModifyArray(string[] array, int index, string newElement)
        {
            array[index] = newElement;
            return array;
        }
    }
}

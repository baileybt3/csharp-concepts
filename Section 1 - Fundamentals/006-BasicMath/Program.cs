/*
 * Basic Math Operators
 * Brandon B
 * 07/26/2026
 */
namespace _006_BasicMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;

            // Addition
            int add = a + b;

            // Subtract
            int sub = a - b;

            // Multiply
            int multiply = a * b;

            // Divide
            int divide = a / b;

            // Modulo (Remainder)
            int mod = a % b;

            string output = MathOutput(a, b, add, multiply, sub, divide, mod);
            Console.WriteLine(output);
            
        }

        private static string MathOutput(int a, int b, int add, int multiply, int sub, int divide, int mod)
        {
            string output = $"{a} + {b} = {add} \n" +
                $"{a} - {b} = {sub} \n" +
                $"{a} * {b} = {multiply} \n" +
                $"{a} / {b} = {divide} \n" +
                $"{a} % {b} = {mod} \n";

            return output;
        }
    }
}

namespace _011_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = "2";
            string secondString = "4";

            int firstNumber = int.Parse(firstString);
            int secondNumber = int.Parse(secondString);

            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}

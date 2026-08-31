namespace _025_StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your weight (lbs): ");
            double weight = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(FormatString(name, age, weight));

        }

        public static string FormatString(string name, int age, double weight)
        {
            string newName = name.Substring(0, 1).ToUpper() + name.Substring(1);

            double dogYears = age * 7;

            decimal newWeight = Convert.ToDecimal(weight / 14);

            return $"Name: {newName}, Age in Dog Years: {dogYears}, Weight: {newWeight}";
        }
    }
}

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --- Calculator ---");
            int option = 0;

            while (option != 5)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("[1]Addition\n"
                                + "[2]Subtraction\n"
                                + "[3]Multiplication\n"
                                + "[4]Division\n"
                                + "[5]Quit"

                );

                if(!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                switch (option)
                {
                    // Addition
                    case 1:
                        Console.Write("Please enter the first number:");
                        if(!double.TryParse(Console.ReadLine(), out double addInput1))
                        {
                            Console.WriteLine("This is not a valid number.");
                            break;
                        }

                        Console.Write("Please enter the second number:");
                        if (!double.TryParse(Console.ReadLine(), out double addInput2))
                        {
                            Console.WriteLine("This is not a valid number.");
                            break;
                        }
                        double addAnswer = Addition(addInput1, addInput2);

                        Console.WriteLine($"{addInput1} + {addInput2} = {addAnswer}");
                        break;

                    // Subtraction
                    case 2:
                        Console.Write("Please enter the first number:");
                        if(!double.TryParse(Console.ReadLine(), out double subInput1)){
                            Console.WriteLine("That is not a valid number.");
                            break;
                        }
                        Console.Write("Please enter the second number:");
                        if (!double.TryParse(Console.ReadLine(), out double subInput2))
                        {
                            Console.WriteLine("That is not a valid number.");
                            break;
                        }
                           
                        double subAnswer = Subtraction(subInput1, subInput2);
                        Console.WriteLine($"{subInput1} - {subInput2} = {subAnswer}");

                        break;

                    // Multiplication
                    case 3:
                        Console.Write("Please enter the first number:");
                        if (!double.TryParse(Console.ReadLine(), out double multiInput1))
                        {
                            Console.WriteLine("That is not a valid number.");
                            break;
                        }
                        Console.Write("Please enter the second number:");
                        if (!double.TryParse(Console.ReadLine(), out double multiInput2))
                        {
                            Console.WriteLine("That is not a valid number.");
                            break;
                        }

                        double multiAnswer = Multiplication(multiInput1, multiInput2);
                        Console.WriteLine($"{multiInput1} * {multiInput2} = {multiAnswer}");

                        break;

                    // Division
                    case 4:
                        Console.Write("Please enter the first number:");
                        if (!double.TryParse(Console.ReadLine(), out double divInput1))
                        {
                            Console.WriteLine("That is not a valid number.");
                            break;
                        }
                        Console.Write("Please enter the second number:");
                        if (!double.TryParse(Console.ReadLine(), out double divInput2))
                        {
                            Console.WriteLine("That is not a valid number.");
                            break;
                        }

                        if (divInput2 == 0)
                        {
                            Console.WriteLine("You cannot divide by zero.");
                            break;
                        }

                        double divAnswer = Division(divInput1, divInput2);
                        Console.WriteLine($"{divInput1} / {divInput2} = {divAnswer}");
                        break;

                    // Quit
                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Please choose a number from 1 through 5.");
                        break;
                }
                
            }

        }


        // Compute Chosen operation
        public static double Addition(double input1, double input2)
        {
            double result = input1 + input2;
            return result;
        }

        public static double Subtraction(double input1, double input2)
        {
            double result = input1 - input2;
            return result;
        }

        public static double Multiplication(double input1, double input2)
        {
            double result = input1 * input2;
            return result;
        }

        public static double Division(double input1, double input2)
        {
            double result = input1 / input2;
            return result;
        }
    }
}

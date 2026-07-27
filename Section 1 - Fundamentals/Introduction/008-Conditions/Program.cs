namespace _008_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Condition Operators\n");

            Console.WriteLine("== : Equal to\n" +
                              "!= : Not equal to\n" +
                              ">  : Greater than\n" +
                              "<  : Less than\n" +
                              ">= : Greater than or equal to\n" +
                              "<= : Less than or equal to\n");

            Console.WriteLine("Logical Operators: \n" +
                              "&& (AND) : Evaluates to true if both conditions are true\n" +
                              "|| (OR)  : Evaluates if at least one condition is true\n" +
                              "! (NOT)  : Reverses the boolean value of the expression\n");

            

            Console.WriteLine(" --- Examples ---");

            bool isBool = true;
            int a = 3;
            int b = 5;

            
            // Equal to
            Console.WriteLine($"If {a} == {b}");
            if(a == b) {
                Console.WriteLine("True\n");
            }
            else
            {
                Console.WriteLine("False\n");
            }

            // Not equal to
            Console.WriteLine($"If {a} != {b}");
            if (a != b)
            {
                Console.WriteLine("True\n");
            }
            else
            {
                Console.WriteLine("False\n");
            }

            // Greater than
            Console.WriteLine($"If {a} > {b}");
            if (a > b)
            {
                Console.WriteLine("True\n");
            } 
            else
            {
                Console.WriteLine("False\n");
            }

            // Less than
            Console.WriteLine($"If {a} < {b}");
            if(a < b)
            {
                Console.WriteLine("True\n");
            }
            else
            {
                Console.WriteLine("False\n");
            }

                isBool = false;
            a = 10;
            b = 10;

            Console.WriteLine($"isBool = {isBool}\n a = {a}\n b = {b}\n");

            Console.WriteLine($"If {a} == {b} && {isBool}");
            if(a == b && isBool)
            {
                Console.WriteLine("True\n");
            }
            else
            {
                Console.WriteLine("False\n");
            }

            Console.WriteLine($"If {a} == {b} || {isBool}");
            if(a == b || isBool)
            {
                Console.WriteLine("True\n");
            }
            else
            {
                Console.WriteLine("False\n");
            }



        }
    }
}

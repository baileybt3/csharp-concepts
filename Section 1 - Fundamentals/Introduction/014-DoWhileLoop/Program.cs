/*
 * Do-While Loop - Executes at least once before checking condition
 * 08/06/2026
 * Brandon Bailey
 */

int sum = 0;
int num = 1;
int count = 0;

do
{
    num *= 2;
    sum = sum + num;
    Console.WriteLine("The sum is: " + sum);

    count++;
} while (count < 10);

Console.WriteLine();

bool isFalse = false;

do
{
    num *= 2;
    sum = 0;
    
    Console.WriteLine("The sum is: " + sum);
} while (isFalse == true);




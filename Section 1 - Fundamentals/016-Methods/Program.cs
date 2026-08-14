/*
 * 016 - Methods
 * Brandon Bailey
 * 08/12/2026
 */

Console.Write("Enter the target number: ");
int userNum = int.Parse(Console.ReadLine());

int[] sumList = new int[userNum];

Console.WriteLine($"\nFinal Sum: { GetSum(userNum, sumList) }");

int GetSum(int userNum, int[] sumList)
{
    int sum = 0;

    for (int i = 0; i < userNum; i++)
    {
        sumList[i] = i + 1;
    }

    for (int j = 0; j < sumList.Length; j++)
    {
        Console.Write(sumList[j] + " ");

        int currNum = sumList[j];
        sum += currNum;

        Console.WriteLine($"Sum: {sum}");
    }

    return sum;

}


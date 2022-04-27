using System;

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(0, 101);
        int dividerThree = 3, dividerFive = 5 ;
        int sum = 0;

        for (int i = number; i > 0; i--)
        {
            if (i % dividerThree == 0 || i % dividerFive == 0)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }
        }
    }
}

using System;

internal class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int number = rand.Next(60, 101);
        int sum = 0;

        for (int i = number; i > 0; i--)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }
        }
    }
}
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int minimumConstellations = 0;
        int maximumConstellations = 101;
        int dividerForStars1 = 3;
        int dividerForStars2 = 5;
        int number = random.Next(minimumConstellations, maximumConstellations);
        int totalNumberStars = 0;

        for (int i = number; i > 0; i--)
        {
            if (i % dividerForStars1 == 0 || i % dividerForStars2 == 0)
            {
                totalNumberStars = totalNumberStars + i;
                Console.WriteLine(totalNumberStars);
            }
        }
    }
}

using System;
class Coinflip
{
    static void Main()
    {
        Random random = new Random();
        int totalflip = 1000;
        int headcount = 0;
        int tailcount = 0;
        for (int i =0; i < totalflip; i++)
        {
            int result = random.Next(2);
            if (result==0)
            {
                headcount++;

            }
            else
            {
                tailcount++;
            }
        }
        double headpercentage = (double)headcount / totalflip * 100;
        double tailpercentage = (double)tailcount / totalflip * 100;
        Console.WriteLine("headcount--" + headcount);
        Console.WriteLine("tailcount--" + tailcount);
        Console.WriteLine("headpercentsge--" + headpercentage);
        Console.WriteLine("tailpercentage--" + tailpercentage);
    }
}
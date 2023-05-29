using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (N): ");
        int n = int.Parse(Console.ReadLine());

        double harmonicNumber = 0.0;
        for (int i = 1; i <= n; i++)
        {
            harmonicNumber += 1.0 / i;
        }

        Console.WriteLine("The {0}th harmonic number is: {1}", n, harmonicNumber);
    }
}

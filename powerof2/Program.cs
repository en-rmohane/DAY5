using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int userInput = int.Parse(Console.ReadLine());

        Console.WriteLine("Powers of 2 table for {0}:", userInput);

        for (int i = 0; i <= userInput; i++)
        {
            Console.WriteLine("2^{0} = {1}", i, Math.Pow(2, i));
        }
    }
}

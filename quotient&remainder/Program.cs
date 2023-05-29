using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int dividend = int.Parse(Console.ReadLine());

        Console.Write("Enter another number (divisor): ");
        int divisor = int.Parse(Console.ReadLine());

        int quotient = dividend / divisor;
        int remainder = dividend % divisor;

        Console.WriteLine("Quotient: {0}", quotient);
        Console.WriteLine("Remainder: {0}", remainder);
    }
}

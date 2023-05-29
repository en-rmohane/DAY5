using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Before swapping:");
        Console.WriteLine("First number: {0}", firstNumber);
        Console.WriteLine("Second number: {0}", secondNumber);

        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;

        Console.WriteLine("After swapping:");
        Console.WriteLine("First number: {0}", firstNumber);
        Console.WriteLine("Second number: {0}", secondNumber);
    }
}

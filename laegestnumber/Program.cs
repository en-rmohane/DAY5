using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int largestNumber = firstNumber;

        if (secondNumber > largestNumber)
        {
            largestNumber = secondNumber;
        }

        if (thirdNumber > largestNumber)
        {
            largestNumber = thirdNumber;
        }

        Console.WriteLine("The largest number is: {0}", largestNumber);
    }
}

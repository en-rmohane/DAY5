using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an alphabet: ");
        char alphabet = Console.ReadLine().ToLower()[0];

        if (char.IsLetter(alphabet))
        {
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine("The entered alphabet is a vowel.");
            }
            else
            {
                Console.WriteLine("The entered alphabet is a consonant.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid alphabet.");
        }
    }
}

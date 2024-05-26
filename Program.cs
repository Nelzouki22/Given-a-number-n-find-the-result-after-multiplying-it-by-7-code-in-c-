using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            int result = n * 7;
            Console.WriteLine("The result after multiplying {0} by 7 is: {1}", n, result);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}


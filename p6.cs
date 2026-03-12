// Factorial of a number
using System;
    class Program
{
    static void Main()
    {
        int number = 5;
        int fact = 1;
        for (int i=1; i <= number; i++)
        {
            fact = fact *i;
        }
        Console.WriteLine(fact);
    }
}

    
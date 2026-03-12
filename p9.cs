// Accepting 2 numbers from user to add 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int i1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine();

        Console.WriteLine("Enter second number");
        int i2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The sum is "+(i1+i2));
    }
}
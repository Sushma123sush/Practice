// Arithmetic Operations
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter the value of a");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value of b");
        int b = Convert.ToInt32(Console.ReadLine());
        
        int sum = add(a,b);
        int diff = subtract(a,b);
        int prod = multiply(a,b);
        int quot = divide(a,b);

        
        Console.Write(sum+"\n");
        Console.Write(diff+"\n");
        Console.Write(prod+"\n");
        Console.Write(quot);
    }
    public static int add(int a, int b)
    {
        return a+b;
    }
    public static int subtract(int a, int b)
    {
        return a-b;
    }
    public static int multiply(int a, int b)
    {
        return a*b;
    }
    public static int divide(int a, int b)
    {
        if(a==0 || b == 0)
        {
            Console.WriteLine("Invalid input");
        }
        
            return a/b;
        
    }
}
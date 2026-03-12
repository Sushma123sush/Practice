// Program to find largest of three numbers
using System;

class Program
{
    static void Main()
    {
        int n1 = 5;
        int n2 = 8;
        int n3 = 9;
        if(n1>n2 && n1 > n3)
        {
            Console.WriteLine("The largest number is "+n1);
        }
        else if(n2>n1 && n2 > n3)
        {
            Console.WriteLine("the largest number is "+n2);
        }
        else
        {
            Console.WriteLine("the largest number is "+n3);
        }
    }
}
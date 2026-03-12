//Reverse a number
using System;
class Program
{
    static void Main()
    {
    int number = 123456;
    int rev = 0;
    while(number>0){
        int rem = number % 10;
        rev = rev * 10 +rem;
        number = number/10;
    }
    Console.WriteLine(rev);
    }
    
}
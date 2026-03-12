// Type casting in C# 
// char -> int -> long -> float -> double (implict type casting) 
// double -> float -> long -> int -> char (Explicit type casting)
using System;
class Program
{
    static void Main(string[] args)
    {
        int i1 = 4;
        double d1 = i1;

        Console.WriteLine(i1);
        Console.WriteLine(d1);

        double ds = 8.9;
        int il = (int) ds;

        Console.WriteLine(il);
        Console.WriteLine(ds);


    }
}

/* It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)*/
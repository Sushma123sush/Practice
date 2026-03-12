// Use of Constructors
using System;
class Program
{
    string name;
    int id;
    Program(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
    static void Main(string[] args)
    {
        Program obj = new Program("abc",22);
        Console.WriteLine("Name is "+obj.name+" ID is "+obj.id);
    }
    
}
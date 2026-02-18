using MyLibrary;
using System;

class Program
{
    static void Main()
    {
        BasicMath math = new BasicMath();

        Console.WriteLine(math.Add(10, 5));
        Console.WriteLine(math.Multiply(4, 3));
        Console.WriteLine(math.Divide(20, 4));
    }
}

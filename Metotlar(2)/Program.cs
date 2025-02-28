using System;

class Program
{
    // Simple method overloading example
    static void PrintMessage()
    {
        Console.WriteLine("Hello, World!");
    }

    static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    static void PrintMessage(string message, int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine(message);
        }
    }

    // Instance method overloading example
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    static void Main(string[] args)
    {
        // Using simple method overloading
        PrintMessage();
        PrintMessage("Hello, C#!");
        PrintMessage("Hello, Overloading!", 3);

        // Using instance method overloading
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(2, 3));
        Console.WriteLine(calc.Add(2.5, 3.5));
        Console.WriteLine(calc.Add(1, 2, 3));
    }
}
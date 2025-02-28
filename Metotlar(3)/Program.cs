using System;

partial class Program
{
    static void Main(string[] args)
    {
        // Extension Method Example
        string example = "Hello, World!";
        Console.WriteLine(example.ReverseString());

        // Recursive Method Example
        int number = 5;
        Console.WriteLine($"Factorial of {number} is {MathExtensions.Factorial(number)}");
    }
}

// Extension Method
public static class StringExtensions
{
    public static string ReverseString(this string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

// Recursive Method
public static class MathExtensions
{
    public static int Factorial(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}
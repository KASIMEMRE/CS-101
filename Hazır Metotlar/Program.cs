using System;

class Program
{
    static void Main()
    {
        string example = "Hello, World!";
        
        // Length
        Console.WriteLine("Length: " + example.Length);

        // ToUpper
        Console.WriteLine("ToUpper: " + example.ToUpper());

        // ToLower
        Console.WriteLine("ToLower: " + example.ToLower());

        // Substring
        Console.WriteLine("Substring: " + example.Substring(7, 5));

        // Replace
        Console.WriteLine("Replace: " + example.Replace("World", "C#"));

        // IndexOf
        Console.WriteLine("IndexOf 'World': " + example.IndexOf("World"));

        // Contains
        Console.WriteLine("Contains 'Hello': " + example.Contains("Hello"));

        // Split
        string[] words = example.Split(' ');
        Console.WriteLine("Split:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Trim
        string padded = "   padded string   ";
        Console.WriteLine("Trim: '" + padded.Trim() + "'");
    }
}
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
public class Calculator
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 6;
        int sum = a + b;
        //dotnet  Console.WriteLine(sum);
        Console.WriteLine("Sum of 2 numbers : " + (a + b));
        Console.WriteLine("Subtract of 2 numbers : " + (a - b));
        Console.WriteLine("Multiplication of 2 numbers : " + (a * b));
        Console.WriteLine("Division of 2 numbers : " + (a / b));
        
    }
}

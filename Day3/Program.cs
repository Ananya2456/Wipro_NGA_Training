// // See https://aka.ms/new-console-template for more information
// //Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main()
    {
        // Declare an array to store 5 names
        string[] names = new string[5];

        // Input from user
        Console.WriteLine("Enter 5 names:");
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"Enter name {i + 1}: ");
            names[i] = Console.ReadLine();
        }

        // Display the names
        Console.WriteLine("\nThe names you entered are:");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Name {i + 1}: {names[i]}");
        }
    }
}


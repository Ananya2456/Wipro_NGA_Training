// See https://aka.ms/new-console-template for more information
using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a jagged array with 3 rows
            int[][] jaggedArray = new int[3][];

            // Initialize each row with different lengths
            jaggedArray[0] = new int[] { 1, 2, 3 };          // Row 0 has 3 elements
            jaggedArray[1] = new int[] { 4, 5 };             // Row 1 has 2 elements
            jaggedArray[2] = new int[] { 6, 7, 8, 9, 10 };   // Row 2 has 5 elements

            // Print the jagged array
            Console.WriteLine("Jagged Array Elements:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Row {i}: ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}


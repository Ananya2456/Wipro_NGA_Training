// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace DelegateInvoiceExample
{
    // Delegate for calculating invoice
    public delegate int CalculateInvoiceDelegate(int tuitionFees, int transportFees);

    // Delegate for printing invoice
    public delegate void PrintInvoiceDelegate(int totalAmount);

    public class Admin
    {
        // Method to calculate invoice
        public int CalculateInvoice(int tuitionFees, int transportFees)
        {
            return tuitionFees + transportFees;
        }

        // Method to print invoice
        public void PrintInvoice(int totalAmount)
        {
            Console.WriteLine("========== Invoice ==========");
            Console.WriteLine($"Total Invoice Amount: {totalAmount}");
            Console.WriteLine("=============================");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();

            // Create delegate instances
            CalculateInvoiceDelegate calcDel = new CalculateInvoiceDelegate(admin.CalculateInvoice);
            PrintInvoiceDelegate printDel = new PrintInvoiceDelegate(admin.PrintInvoice);

            // Input fees
            int tuitionFees = 50000;
            int transportFees = 10000;

            // Calculate invoice
            int total = calcDel(tuitionFees, transportFees);

            // Print invoice
            printDel(total);

            Console.ReadLine();
        }
    }
}

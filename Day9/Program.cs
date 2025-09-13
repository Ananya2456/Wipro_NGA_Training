// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace DelegateInvoiceExample
{
    // Delegate for calculating invoice
    public delegate int CalculateInvoiceDelegate(int tuitionFees, int transportFees);

    // Delegate for printing invoice
    public delegate void PrintInvoiceDelegate(int tuitionFees, int transportFees);

    public class Admin
    {
        // Method to calculate invoice
        public int CalculateInvoice(int tuitionFees, int transportFees)
        {
            return tuitionFees + transportFees;
        }

        // Print Page 1 (Actual Invoice)
        public void PrintInvoicePage1(int tuitionFees, int transportFees)
        {
            int total = CalculateInvoice(tuitionFees, transportFees);
            Console.WriteLine("========== Invoice Page 1 ==========");
            Console.WriteLine($"Tuition Fees   : {tuitionFees}");
            Console.WriteLine($"Transport Fees : {transportFees}");
            Console.WriteLine($"Total Amount   : {total}");
            Console.WriteLine("====================================");
        }

        // Print Page 2 (100% Tuition Deduction)
        public void PrintInvoicePage2(int tuitionFees, int transportFees)
        {
            int total = transportFees; // Tuition waived fully
            Console.WriteLine("========== Invoice Page 2 ==========");
            Console.WriteLine($"Tuition Fees   : {tuitionFees} (100% Deduction Applied)");
            Console.WriteLine($"Transport Fees : {transportFees}");
            Console.WriteLine($"Total Amount   : {total}");
            Console.WriteLine("====================================");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();

            // Delegates
            CalculateInvoiceDelegate calcDel = new CalculateInvoiceDelegate(admin.CalculateInvoice);
            PrintInvoiceDelegate page1Del = new PrintInvoiceDelegate(admin.PrintInvoicePage1);
            PrintInvoiceDelegate page2Del = new PrintInvoiceDelegate(admin.PrintInvoicePage2);

            // Input
            int tuitionFees = 50000;
            int transportFees = 10000;

            // Print both invoices
            page1Del(tuitionFees, transportFees);
            page2Del(tuitionFees, transportFees);

            Console.ReadLine();
        }
    }
}


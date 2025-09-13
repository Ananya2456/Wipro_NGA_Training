// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// 
// class ABC {

//     // Delegate Declaration for add operations and Print 
//     // parameterized Delegates responsible for method invocation at runtime
//     public delegate int AddDelegate(int a, int b);

//     public delegate void PrintDelegate(int result);

//     public static void Main(string[] args) {

//         //Assign Methods to delegates
//         AddDelegate addDelegate = AddNumbers;
      
//         /*int a ;
//         // a =30;
//         ABC a1 = new ABC();
//         AddDelegate ad = AddNumbers;*/

//         PrintDelegate print = PrintResult;

//         // calling/using delegate
//        int sum = addDelegate(10, 30);
//         print(sum);
    
//     }


//     static int AddNumbers(int x , int y)
//     { return x + y; }

//     static void PrintResult(int result)
//     { 
//         Console.WriteLine(result);
//     }
// }
// using System;

// public class Program
// {
//     // Delegate to calculate invoice
//     public delegate int CalculateInvoice(int tuitionFees, int transportFees);

//     // Delegate to print invoice
//     public delegate void PrintInvoice(int totalAmount);

//     public static void Main(string[] args)
//     {
//         // Admin logic to calculate total fees
//         CalculateInvoice calculate = delegate (int tuition, int transport)
//         {
//             return tuition + transport;
//         };

//         // Admin logic to print the invoice
//         PrintInvoice print = delegate (int total)
//         {
//             Console.WriteLine("----- Invoice Summary -----");
//             Console.WriteLine("Total Invoice Amount: ₹" + total);
//         };

//         // Example usage
//         int tuitionFees = 50000;
//         int transportFees = 8000;

//         int total = calculate(tuitionFees, transportFees);
//         print(total);
//     }
// }

using System;

public delegate void InvoiceDelegate(int tuitionFee, int transportFee);

public class InvoicePrinter
{
    // Page 1: Print actual invoice
    public static void PrintActualInvoice(int tuitionFee, int transportFee)
    {
        int total = tuitionFee + transportFee;
        Console.WriteLine("---- Invoice Page 1 ----");
        Console.WriteLine($"Tuition Fee   : {tuitionFee}");
        Console.WriteLine($"Transport Fee : {transportFee}");
        Console.WriteLine($"Total Amount  : {total}");
        Console.WriteLine("-------------------------\n");
    }

    // Page 2: Tuition 100% deduction
    public static void PrintDeductedInvoice(int tuitionFee, int transportFee)
    {
        tuitionFee = 0; // 100% deduction
        int total = tuitionFee + transportFee;
        Console.WriteLine("---- Invoice Page 2 ----");
        Console.WriteLine("Tuition Fee   : 0 (100% scholarship applied)");
        Console.WriteLine($"Transport Fee : {transportFee}");
        Console.WriteLine($"Total Amount  : {total}");
        Console.WriteLine("-------------------------\n");
    }
}

public class Program
{
    public static void Main()
    {
        int tuition = 50000;
        int transport = 10000;

        // Page 1: Actual invoice
        InvoiceDelegate invoice1 = new InvoiceDelegate(InvoicePrinter.PrintActualInvoice);
        invoice1(tuition, transport);

        // Page 2: Deducted invoice
        InvoiceDelegate invoice2 = new InvoiceDelegate(InvoicePrinter.PrintDeductedInvoice);
        invoice2(tuition, transport);
    }
}



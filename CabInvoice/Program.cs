using System;

namespace CabInvoice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InvoiceGenerator getMethod = new InvoiceGenerator(10.0, 5);
            double fare = getMethod.CalculateFare();
            Console.WriteLine("Fare: " + fare);
        }
    }
}

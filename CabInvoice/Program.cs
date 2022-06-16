using System;

namespace CabInvoice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ride[] ride = { new Ride(10, 10), new Ride(10, 5)};
            InvoiceGenerator getMethod = new InvoiceGenerator();
            double fare = getMethod.MultipleRides(ride);
        }
    }
}

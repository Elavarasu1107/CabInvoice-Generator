namespace CabInvoice_Testing
{
    public class Tests
    {
        [Test]
        public void GivenDistanceAndTime_ShouldReturnExpectedTotalFare()
        {
            double distance = 10;
            int time = 5, expected = 105;
            CabInvoice.InvoiceGenerator getMethod = new CabInvoice.InvoiceGenerator(distance, time);
            Assert.AreEqual(expected, getMethod.CalculateFare());
        }
    }
}
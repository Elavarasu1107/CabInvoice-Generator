using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoice
{
    public class EnhancedInvoice
    {
        public double numberOfRides;
        public double totalFare;
        public double averageFare;
        public EnhancedInvoice(double numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.numberOfRides;
        }
    }
}

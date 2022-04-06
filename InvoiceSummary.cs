using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        private int numberOfRides;
        private double totalfare;
        private double averagefare;

        public InvoiceSummary(int numberofRides,double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalfare = totalFare; ;
            this.averagefare = this.totalfare/this.numberOfRides;   
        }

        public override bool Equals(object? obj)
        {
            if(obj==null)
                return false;
            if(!(obj is InvoiceSummary))
                return false;
            InvoiceSummary inputObject  = (InvoiceSummary)obj;


            return this.numberOfRides == inputObject.numberOfRides && this.totalfare == inputObject.totalfare && this.averagefare == inputObject.averagefare;


        }

        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode();
        }
    }
}
        

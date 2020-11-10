using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BillInheritance
{
    class Bill
    {
        public double Subtotal { get; set; }
        public double TaxRate { get; set; }

        public Bill(double subtotal, double taxrate) //overload constructor
        {
            Subtotal = subtotal;
            TaxRate = taxrate;
        }

        public Bill() //default constructor
        {

        }

        public virtual double CalcTotal()
        {
            double totalBill = (Subtotal * (1 + TaxRate));

            return totalBill;
            
        }

    }
}

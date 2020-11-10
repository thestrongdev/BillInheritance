using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BillInheritance
{
    class Bill
    {
 
        private double _subtotal;
        private double _taxrate;

        public double Subtotal { get => _subtotal; set => _subtotal = value; }
        public double TaxRate { get => _taxrate; set => _taxrate = value; }

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

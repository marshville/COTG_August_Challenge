using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COTGPetshop.Common
{
    public class TaxBreakdown
    {
        public TaxBreakdown(decimal grossPrice, decimal vAT, decimal legTax)
        {
            this.Gross = grossPrice;
            this.VAT = vAT;
            this.LegTax = legTax;            
        }
        public decimal Gross { get; private set; }
        public decimal VAT { get; private set; }
        public decimal LegTax { get; private set; }

        public decimal NetOfVat
        {
            get { return Gross - VAT; }
        }

        public decimal NetOfTax
        {
            get { return Gross - (VAT + LegTax); }
        }
    }
}

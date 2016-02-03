using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COTGPetshop.Common
{
    public class SaleItem
    {
        public SaleItem(IProduct product, DateTime saleDate, TaxBreakdown taxBreakdown)
        {
            this.Product = product;
            this.SaleDate = saleDate;
            this.TaxBreakdown = taxBreakdown;
        }
        public DateTime SaleDate { get; private set; }
        public IProduct Product { get; private set; }
        public TaxBreakdown TaxBreakdown { get; private set; }
        public override string ToString()
        {
            return String.Format("{0} ***Sale*** : {1}", SaleDate.ToShortTimeString(), Product.Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COTGPetshop.Common
{
    public class Product : IProduct
    {
        public String Name { get; private set; }
        public Decimal GrossPrice { get; private set; }
        private readonly ITaxStrategy _taxStrategy;
        
        public Product(string name, decimal grossPrice, ITaxStrategy taxStrategy)
        {
            this.Name = name;
            this.GrossPrice = grossPrice;
            this._taxStrategy = taxStrategy;
        }

        public SaleItem GenerateSale()
        {
            return new SaleItem(this, DateTime.Now, _taxStrategy.CalculateTaxFromGross(GrossPrice));
        }
    }
}

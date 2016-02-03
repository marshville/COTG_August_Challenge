using COTGPetshop.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COTGPetshop.PosApp
{
    public class POSModel
    {
        public BindingList<IProduct> Products { get; private set; }
        public BindingList<SaleItem> Sales { get; private set; }
        public const String POSTitle = @"Fred's Pet Shop";

        public POSModel()
        {
            Products = new BindingList<IProduct>();
            Sales = new BindingList<SaleItem>();
        }

        public async Task InitialiseAsync()
        {
            await Task.Delay(5000);
            InitialisePetInventory();                    
        }

        private void InitialisePetInventory()
        {            
            Products.Clear();
            Products.Add(new Product("Rabbit", 25.0M, new PetTaxStrategy(18, 10, 4)));
            Products.Add(new Product("Squirrel", 10.0M, new PetTaxStrategy(18, 10, 4)));
            Products.Add(new Product("Rat", 15.0M, new PetTaxStrategy(18, 10, 4)));
            Products.Add(new Product("Kangaroo", 80.0M, new PetTaxStrategy(18, 10, 2)));
            Products.Add(new Product("Tarantula", 75.0M, new PetTaxStrategy(18, 10, 8)));
        }


        public void MakeSale(IProduct product)
        {
            if (product == null)
                throw new ArgumentNullException("product");

            var saleItem = product.GenerateSale();
            Sales.Add(saleItem);
        }

        public TaxBreakdown CalculateDailySales()
        {
            List<SaleItem> todaysSales = Sales.OrderByDescending(s => s.SaleDate)
                                               .Where(s => s.SaleDate.Date == DateTime.Today).ToList();

            return new TaxBreakdown(todaysSales.Sum(s => s.TaxBreakdown.Gross),
                todaysSales.Sum(s => s.TaxBreakdown.VAT),
                todaysSales.Sum(s => s.TaxBreakdown.LegTax));
        }
    }
}

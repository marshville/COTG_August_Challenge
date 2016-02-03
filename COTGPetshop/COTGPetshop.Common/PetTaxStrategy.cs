using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COTGPetshop.Common
{
    public class PetTaxStrategy : ITaxStrategy
    {
        private readonly decimal _vatRate;
        private readonly  decimal _legRate;
        private readonly  Int16 _legCount;
        

        public PetTaxStrategy(decimal vatRate, decimal legRate, Int16 legCount)
        {
            this._vatRate = vatRate;
            this._legRate = legRate;
            this._legCount = legCount;
        }

        public TaxBreakdown CalculateTaxFromGross(decimal grossPrice)
        {
            var vat = CalculateVatFromGross(grossPrice);
            var legTax = CalculateLegTax(grossPrice);

            var item = new TaxBreakdown(grossPrice,vat,legTax);

            return item;
        }

        public TaxBreakdown CalculateTaxFromNet(decimal netPrice)
        {
            var vat = CalculateVatFromNet(netPrice);
            var grossPrice = netPrice + vat;
            var legTax = CalculateLegTax(grossPrice);

            var item = new TaxBreakdown(grossPrice, vat, legTax);

            return item;
        }

        public decimal CalculateVatFromGross(decimal grossPrice)
        {
            return Math.Round((grossPrice/(100.00M + _vatRate)*_vatRate), 2);
        }

        public decimal CalculateVatFromNet(decimal netPrice)
        {
            return Math.Round((netPrice*_vatRate/100.00M), 2);
            
        }

        public decimal CalculateLegTax(decimal grossPrice)
        {
            return Math.Round((_legCount * _legRate * grossPrice / 100.00M), 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COTGPetshop.Common
{
    public interface IProduct
    {
        string Name { get; }
        decimal GrossPrice { get; }
        SaleItem GenerateSale();
    }
}

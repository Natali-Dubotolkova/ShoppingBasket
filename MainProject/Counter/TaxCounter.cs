using CountBasket.Constants;
using CountBasket.Interfaces;
using CountBasket.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CountBasket.Counter
{
    public static class TaxCounter
    {
        private static ITaxCounter taxCounter;

        public static void Counter(List<Product> productsList)
        {
            string title;
            foreach (var product in productsList)
            {
                title = product.title.ToLower();
                if (string.IsNullOrEmpty(title)) throw new ArgumentNullException(nameof(title), "Title cannot be null");
                if (title.Contains(TaxConstants.IMPORTED_TAG))
                {
                    taxCounter = new DutyTaxCounter();
                    product.priceWithTax += taxCounter.GetTax(product.unitPrice);
                }
                if (!TaxConstants.EXCLUDING_PRODUCTS.Any(str => title.Contains(str)))
                {
                    taxCounter = new BasicTaxCounter();
                    product.priceWithTax += taxCounter.GetTax(product.unitPrice);
                }
            }
        }
    }
}

using CountBasket.Counter;
using CountBasket.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CountBasket.Models
{
    public class Basket : IBasket
    {
        public List<Product> products;
        public Basket(List<Product> products)
        {
            this.products = new List<Product>();
            this.products.AddRange(products.ToArray());
            TaxCounter.Counter(this.products);
        }

        public double SumTotalWithoutTax => products.Sum(item => item.unitPrice);

        public double SumTotalWithTax => products.Sum(item => item.priceWithTax);

        public double GetBasketTax() => SumTotalWithTax - SumTotalWithoutTax;
    }
}

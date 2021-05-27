using System;
using System.Collections.Generic;
using System.Globalization;
using CountBasket.Models;

namespace CountBasket.Utils
{
    public class ConsolePrint
    {
        public static void PrintResult(List<Basket> baskets)
        {
            var i = 0;
            foreach (var basket in baskets)
            {
                Console.WriteLine("Output {0}:", ++i);
                foreach (var product in basket.products)
                {
                    Console.WriteLine(product.productCount + " " + product.title + ": " + product.priceWithTax.ToString("N2", new CultureInfo("en-US")));
                }
                Console.WriteLine("Sales Taxes: " + basket.GetBasketTax().ToString("N2", new CultureInfo("en-US")));
                Console.WriteLine("Total: " + basket.SumTotalWithTax.ToString("N2", new CultureInfo("en-US")));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using CountBasket.Models;

namespace CountBasket.Utils
{
    public class GenerateData
    {
        private static readonly List<List<Product>> shoppingLists = new();
        public static List<List<Product>> GenerateDataFromString(string data)
        {
            if (string.IsNullOrEmpty(data)) throw new ArgumentNullException(nameof(data), "Please, enter the data");
            var basketArray = Regex.Split(data, @"^[\r\n]", RegexOptions.Multiline);

            foreach (var (lines, productsInBasket) in from basket in basketArray
                                                      let lines = basket.Split('\n')
                                                      let productsInBasket = new List<Product>()
                                                      select (lines, productsInBasket))
            {
                foreach (var product in lines)
                {
                    if (product.Contains("Shopping Basket") || string.IsNullOrEmpty(product)) continue;
                    var oneProduct = product.Trim();
                    var start_index = oneProduct.IndexOf(' ') + 1;
                    var end_index = oneProduct.LastIndexOf(' ') - 3;
                    var length = end_index - start_index;

                    var productCount = Convert.ToInt32(oneProduct.Split(' ').First());
                    var title = oneProduct.Substring(start_index, length);
                    var productCost = double.Parse(oneProduct.Split(' ').Last(), CultureInfo.InvariantCulture);

                    if (productCost < 0) throw new ArgumentException("Product price cannot be less than 0");

                    productsInBasket.Add(new Product(productCount, title, productCost));

                }

                shoppingLists.Add(productsInBasket);
            }
            return shoppingLists;
        }
    }
}

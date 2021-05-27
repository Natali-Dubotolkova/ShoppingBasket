using System.Collections.Generic;
using System.Linq;
using CountBasket.Models;
using CountBasket.Utils;
using System;
using CountBasket.Counter;

namespace CountBasket
{
    public class Program
    {
        private static List<List<Product>> shoppingLists = new();
        private static List<Basket> baskets = new();
        static void Main(string[] args)
        {
            var data = @"Shopping Basket 1:
                       1 16lb bag of Skittles at 16.00
                       1 Walkman at 99.99
                       1 bag of microwave Popcorn at 0.99

                       Shopping Basket 2:
                       1 imported bag of Vanilla-Hazelnut Coffee at 11.00
                       1 Imported Vespa at 15,001.25

                       Shopping Basket 3:
                       1 imported crate of Almond Snickers at 75.99
                       1 Discman at 55.00
                       1 Imported Bottle of Wine at 10.00
                       1 300# bag of Fair-Trade Coffee at 997.99";


            shoppingLists = GenerateData.GenerateDataFromString(data);
            CountAllShoppingBaskets();
            ConsolePrint.PrintResult(baskets);

            Console.Read();
        }

        public static void CountAllShoppingBaskets() => baskets.AddRange(shoppingLists.Select(shoppingList => CountShoppingBasket(shoppingList)));
        private static Basket CountShoppingBasket(List<Product> products) => new(products);
    }
}

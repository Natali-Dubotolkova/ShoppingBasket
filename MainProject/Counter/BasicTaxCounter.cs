using CountBasket.Constants;
using CountBasket.Interfaces;
using System;

namespace CountBasket.Counter
{
    public class BasicTaxCounter : ITaxCounter
    {
        public double GetTax(double price) => Math.Ceiling(price * TaxConstants.BASIC_SALES_TAX*20)/20;
    }
}

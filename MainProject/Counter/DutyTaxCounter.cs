using CountBasket.Interfaces;
using CountBasket.Constants;
using System;

namespace CountBasket.Counter
{
    public class DutyTaxCounter : ITaxCounter
    {
        public double GetTax(double price) => Math.Ceiling(price * TaxConstants.IMPORT_DUTY_TAX * 20) / 20;
    }
}

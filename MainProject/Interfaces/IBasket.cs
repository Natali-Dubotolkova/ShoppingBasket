namespace CountBasket.Interfaces
{
    interface IBasket
    {
        public double SumTotalWithoutTax { get; }
        public double SumTotalWithTax { get; }
        public double GetBasketTax();
    }
}

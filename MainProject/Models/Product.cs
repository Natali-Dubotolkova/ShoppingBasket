namespace CountBasket.Models
{
    public class Product
    {
        public int productCount;
        public string title;
        public double unitPrice;
        public double priceWithTax;
        public Product(int productCount, string title, double unitPrice)
        {
            this.productCount = productCount;
            this.title = title;
            this.unitPrice = unitPrice;
            priceWithTax = unitPrice;
        }
    }

}

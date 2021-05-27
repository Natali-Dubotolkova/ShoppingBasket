namespace CountBasket.Constants
{
    public static class TaxConstants
    {
        public static readonly double BASIC_SALES_TAX = 0.1;
        public static readonly double IMPORT_DUTY_TAX = 0.05;

        public static readonly string[] EXCLUDING_PRODUCTS = { "candy", "popcorn", "coffee", "skittles", "snickers" };

        public static readonly string IMPORTED_TAG = "imported";
    }
}

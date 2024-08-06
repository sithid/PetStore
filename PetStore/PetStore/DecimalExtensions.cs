namespace PetStore
{
    static class DecimalExtensions
    {
        public static decimal DiscountThisPrice(this decimal value)
        {
            return Math.Round(value * .9M, 2);
        }
    }
}

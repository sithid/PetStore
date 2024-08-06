namespace PetStore
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityOnHand { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Product: {Name}, Description: {Description}, Quantity In Stock: {QuantityOnHand}";
        }
    }
}

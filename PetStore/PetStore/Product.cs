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
            return $"Product Name: {Name}, Description: {Description}, Price: {Price}, Quantity In Stock: {QuantityOnHand}";
        }
    }
}

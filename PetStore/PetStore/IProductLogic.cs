namespace PetStore
{
    public interface IProductLogic
    {
        public void AddProduct( Product product);
        public void RemoveProduct( Product product );
        public List<Product> GetAllProducts();
        public Product GetProductByName(string name);
        public List<string> GetOnlyInStockProducts();
        public List<string> GetOutOfStockProducts();
    }
}

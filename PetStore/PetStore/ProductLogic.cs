using System;
using System.Collections;

namespace PetStore
{
    public class ProductLogic
    {
        private List<Product> _products;

        public ProductLogic()
        {
            _products = new List<Product>();
        }

        public void AddProduct( Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct( Product product )
        {
            _products.Remove(product);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}

using System;
using System.Collections;

namespace PetStore
{
    public class ProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashes;
        private Dictionary<string, CatFood> _catFoods;

        public ProductLogic()
        {
            _products = new List<Product>();
            _dogLeashes = new Dictionary<string, DogLeash>();
            _catFoods = new Dictionary<string, CatFood>();

            AddProduct(new DogLeash
            {
                Name = "Leather Leash",
                Description = "A Leather Leash",
                Price = 26.99M,
                QuantityOnHand = 5,
                Material = "Nylon",
                LengthInches = 60
            });

            AddProduct(new DogLeash
            {
                Name = "Bedazzled Leash",
                Description = "A Bedazzled Leash",
                Price = 19.99M,
                QuantityOnHand = 0,
                Material = "Nylon",
                LengthInches = 60
            });
        }

        public void AddProduct( Product product)
        {
            _products.Add(product);

            if( product is DogLeash )
            {
                DogLeash leash = product as DogLeash;

                if( leash != null )
                    _dogLeashes.Add( leash.Name, leash );
            }
            else if (product is CatFood )
            {
                CatFood food = product as CatFood;

                if( food != null )
                    _catFoods.Add( food.Name, food );
            }
        }

        public void RemoveProduct( Product product )
        {
            _products.Remove(product);

            if( product is DogLeash )
                _dogLeashes.Remove( product.Name );
            else if (product is CatFood )
                _catFoods.Remove( product.Name );

        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public DogLeash GetDogLeashByName( string name)
        {
            try{ return _dogLeashes[name]; }
            catch( Exception e ){ return null; }
        }

        public CatFood GetCatFoodByName(string name)
        {
            return _catFoods[name];
        }
    }
}

namespace PetStore
{
    public class ProductLogic : IProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashes;

        public ProductLogic()
        {
            _products = new List<Product>();
            _dogLeashes = new Dictionary<string, DogLeash>();

            AddProduct(new DogLeash
            {
                Name = "Leather Leash",
                Description = "A Leather Leash",
                Price = 26.99M,
                QuantityOnHand = 5,
                Material = "Leather",
                LengthInches = 60
            });

            AddProduct(new DogLeash
            {
                Name = "Nylon Leash",
                Description = "A nylon Leash",
                Price = 26.99M,
                QuantityOnHand = 5,
                Material = "Nylon",
                LengthInches = 60
            });

            AddProduct(new DogLeash
            {
                Name = "Black Nylon Leash",
                Description = "A black nylon Leash",
                Price = 26.99M,
                QuantityOnHand = 0,
                Material = "Nylon",
                LengthInches = 60
            });

            AddProduct(new DogLeash
            {
                Name = "Pink Nylon Leash",
                Description = "A pink nylon Leash",
                Price = 26.99M,
                QuantityOnHand = 1,
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
        }

        public void RemoveProduct( Product product )
        {
            _products.Remove(product);

            if( product is DogLeash )
                _dogLeashes.Remove( product.Name );
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

        public List<string> GetOnlyInStockProducts()
        {
            List<string> inStockProductNames = new List<string>();

            foreach( Product product in _products )
            {
                if (product.QuantityOnHand > 0)
                    inStockProductNames.Add(product.Name);
            }

            return inStockProductNames;
        }

        public List<string> GetOutOfStockProducts()
        {
            return _products.Where(p => p.QuantityOnHand == 0).Select(p => p.Name).ToList();
        }
    }
}

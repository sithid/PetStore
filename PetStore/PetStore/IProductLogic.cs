﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public interface IProductLogic
    {
        public void AddProduct( Product product);
        public List<Product> GetAllProducts();
        public DogLeash GetDogLeashByName(string name);
        public List<string> GetOnlyInStockProducts();
        public List<string> GetOutOfStockProducts();
    }
}

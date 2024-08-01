using System;

namespace PetStore
{
    public class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool IsKittenFood { get; set; }

        public override string ToString()
        {
            return base.ToString() + String.Format("Weight: {0}, Kittens: {1}", WeightPounds, IsKittenFood ? "Yes" : "No");
        }
    }
}

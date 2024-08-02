using System;

namespace PetStore
{
    public class CatFood : Product
    {
        public bool IsKittenFood { get; set; }

        public override string ToString()
        {
            return base.ToString() + (IsKittenFood ? ", Kitten Food" : "Not Kitten Food");
        }
    }
}

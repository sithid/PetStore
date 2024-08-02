using System;

namespace PetStore
{
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material {  get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Length: {LengthInches}, Material: {Material}";
        }
    }
}

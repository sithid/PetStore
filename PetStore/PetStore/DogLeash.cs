using System;

namespace PetStore
{
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material {  get; set; }

        public DogLeash() : this( 5, "Nylon")
        {
        }

        public DogLeash( int length, string mat ) : base()
        {
            LengthInches = length;
            Material = mat;
        }

        public override string ToString()
        {
            return base.ToString() + $", Length: {LengthInches}, Material: {Material}";
        }
    }
}

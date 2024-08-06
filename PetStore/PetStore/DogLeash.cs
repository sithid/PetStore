namespace PetStore
{
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material {  get; set; }

        public DogLeash()
        {
            this.QuantityOnHand = 1;
            this.LengthInches = 36;
        }

        public override string ToString()
        {
            return base.ToString() + $", Length: {LengthInches}, Material: {Material}";
        }
    }
}

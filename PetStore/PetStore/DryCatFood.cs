namespace PetStore
{
    public class DryCatFood : CatFood
    {
        public double WeightPounds { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Weight: {WeightPounds}";
        }
    }
}

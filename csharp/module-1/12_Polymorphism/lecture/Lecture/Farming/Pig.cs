namespace Lecture.Farming
{
    public class Pig : FarmAnimal, ISellable // inherits from FarmAnaim, implements from ISellable
    {
        public decimal Price { get; }
        public Pig() : base("Pig", "oink")
        {
            Price = 60;
        }
    }
}

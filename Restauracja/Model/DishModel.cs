namespace Restauracja.Model
{
    public class DishModel
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Price}zł";
        }
    }
}
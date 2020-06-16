namespace prjCadVisu.Model
{
    public class Product
    {
        public string Description { get; set; }

        public double Value { get; set; }

        public Product(string description, double value)
        {
            Description = description;
            Value = value;
        }
    }
}

namespace WindowsFormsApp1
{
    public class Product
    {
        public Product()
        {
        }

        public string Name { get; set; }
        public string Country { get; set; }
        public string Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Country} - {Price}";
        }

    }
}
namespace Księgarnia.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public int Status { get; set; }

        public string Detail { get; set; }

        public string Publisher { get; set; }

        public string Author { get; set; }

        public string Producer { get; set; }
    }
}

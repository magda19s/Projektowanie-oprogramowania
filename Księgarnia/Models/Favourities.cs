namespace Księgarnia.Models
{
    public class Favourities
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public Article Article { get; set; }
        public int ArticleId { get; set; }  
    }
}

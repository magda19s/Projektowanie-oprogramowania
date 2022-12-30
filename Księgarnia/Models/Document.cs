namespace Księgarnia.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int NIP { get; set; }
        public int REGON { get; set; }
        public DocumentKind Kind { get; set; }
        public int DocumentKindId { get; set; }
    }
}

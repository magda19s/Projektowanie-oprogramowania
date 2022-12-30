namespace Księgarnia.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public PaymentMethod Method { get; set; }
        public int PaymentMethodId { get; set; }
    }
}

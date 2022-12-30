using System;

namespace Księgarnia.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime Date { get; set; }

        public int IdParcelLocker { get; set; }
        
        public DeliveryMethod Method { get; set; }
        public int DeliveryMethodId { get; set; }

        public Address Address { get; set; }
        public int AddressId { get; set; }

    }
}

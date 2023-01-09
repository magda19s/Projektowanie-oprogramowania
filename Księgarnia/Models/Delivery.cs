using System;
using System.Diagnostics.CodeAnalysis;

namespace Księgarnia.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime Date { get; set; }

        [AllowNull]
        public int ParcelLockerId { get; set; }

        public ParcelLocker ParcelLocker { get; set; } 

        public DeliveryMethod Method { get; set; }
        [AllowNull]
        public int DeliveryMethodId { get; set; }

        
        public Address Address { get; set; }
        [AllowNull]
        public int AddressId { get; set; }

    }
}

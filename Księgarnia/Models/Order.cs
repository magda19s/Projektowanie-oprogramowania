using System;
using System.Collections.Generic;

namespace Księgarnia.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public double Price { get; set; }
        public Document Document { get; set; }
        public int DocumentId { get; set; }
        public Delivery Delivery { get; set; }
        public int DeliveryId { get; set; }

        public Payment Payment { get; set; }
        public int PaymentId { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public ICollection<OrderItem> Items { get; set; }

    }
}

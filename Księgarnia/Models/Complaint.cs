using System;
using System.Collections.Concurrent;

namespace Księgarnia.Models
{
    public class Complaint
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Detail { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        
        public Order Order { get; set; }

        public int OrderId { get; set; }
    }
}

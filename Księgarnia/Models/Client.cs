using System.Collections;
using System.Collections.Generic;

namespace Księgarnia.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Points { get; set; }
        public double Discount { get; set; }
        

        public ICollection<Order> Orders { get; set; }
    }
}

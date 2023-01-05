using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Księgarnia.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public int Points { get; set; }
        public double Discount { get; set; }
        

        public ICollection<Order> Orders { get; set; }
    }
}

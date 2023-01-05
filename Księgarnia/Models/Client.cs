using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace Księgarnia.Models
{
    public class Client : IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Login { get; set; }
        public int Points { get; set; }
        public double Discount { get; set; }
        

    }
}

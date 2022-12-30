using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Księgarnia.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Article> Article { get; set; }

    }
}

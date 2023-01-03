using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Księgarnia.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00} zł")]
        public double Price { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public int Amount { get; set; }

        public string Detail { get; set; }

        public string Publisher { get; set; }

        public string Author { get; set; }

        public string Producer { get; set; }

        public string FilePath { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile Image { get; set; }
    }
}

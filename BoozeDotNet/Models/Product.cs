using System.ComponentModel.DataAnnotations;

namespace BoozeDotNet.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Range(0.01, 100000, ErrorMessage = "Sorry but that number is just ridiculous")]
        public double Price { get; set; }
        public string? Description { get; set; }
    }
}

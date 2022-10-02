using System.ComponentModel.DataAnnotations;

namespace BoozeDotNet.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        // add nullable child ref to Product model
        public List<Product>? Products { get; set; }
    }
}

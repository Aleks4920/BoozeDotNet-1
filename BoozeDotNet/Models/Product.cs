using System.ComponentModel.DataAnnotations;

namespace BoozeDotNet.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }

        [Range(0.01, 100000, ErrorMessage = "Sorry but that number is just ridiculous")]
        public double Price { get; set; }

        [MaxLength(4000)]
        public string? Description { get; set; }

        public string? Photo { get; set; }

        // FK for Parent Category
        public int CategoryId { get; set; }

        // Parent ref for auto-joins
        public Category? Category { get; set; }
    }
}

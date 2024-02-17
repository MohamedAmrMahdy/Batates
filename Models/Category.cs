using System.ComponentModel.DataAnnotations;

namespace Batates.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string? ImageURL { get; set; }
        public virtual List<Restaurant>? Restaurants { get; }
    }
}

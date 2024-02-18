using System.ComponentModel.DataAnnotations;

namespace Batates.Models
{
    public enum State
    {
        Closed,
        Disabled,
        Busy,
        Opened
    }
    public class Restaurant
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string? ImageURL { get; set; }
        [Required]
        public State State { get; set; }
        [Required]
        public string ContactNo { get; set; }
        public virtual List<Product>? Products { get; set; }
        public virtual List<Category>? Categories { get; set; }
    }
}
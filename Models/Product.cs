using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Batates.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; } = 0;
        public string? ImageURL { get; set; }
        public string? ExtraDetails { get; set; }
        [ForeignKey("Restaurant")]
        [Display(Name= "Restaurant")]
        public int RestaurantID { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        public virtual List<Order>? Orders { get; }
        public virtual List<OrderProduct>? OrderProducts { get; }
    }
}
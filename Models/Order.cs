using Batates.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Batates.Models
{
    public enum PaymentMethod
    {
        COD,
        CC,
        ExternalPayment
    }
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        [Required]
        [EnumDataType(typeof(PaymentMethod))]
        public PaymentMethod PaymentMethod { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        [EnumDataType(typeof(OrderState))]
        public OrderState State { get; set; }
        public string? ExtraDetails { get; set; }
        public virtual List<Product>? Products { get; set; }
        public virtual List<OrderProduct>? OrderProducts { get; set; }
        public ApplicationUser ApplicationUser { get; set; }



    }
}
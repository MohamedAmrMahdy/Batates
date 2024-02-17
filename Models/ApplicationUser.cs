using Batates.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Batates.Models
{
    public class ApplicationUser : IdentityUser
    {
        //[Required]
        public string? Fullname { get; set; }
        //[Required]
        public Gender? Gender { get; set; }
        //[Required]
        public string? ContactNo {  get; set; }
        public string? Address { get; set; }
        
        public int CartID {  get; set; }
        public virtual Cart? Cart {  get; set; }

        //public virtual List<Order>? Orders { get; set; }
        //public virtual List<Product>? Wishlist { get; set; }

    }
}

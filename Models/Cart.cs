using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Batates.Models
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        public List<CartProduct> Products { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}

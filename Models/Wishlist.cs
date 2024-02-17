using System.ComponentModel.DataAnnotations.Schema;

namespace Batates.Models
{
    public class Wishlist
    {
        public int ID { get; set; }

        public List<WishedItem> WishedProducts { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}

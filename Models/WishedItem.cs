namespace Batates.Models
{
    public class WishedItem
    {
        public int ID { get; set; }
        public virtual Product Product { get; set; }
    }
}
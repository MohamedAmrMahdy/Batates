namespace Batates.Models
{
    public class CartProduct
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product {  get; set; }
    }
}

using Batates.Data;
using Batates.Models;
using Batates.Repo.IRepo;

namespace Batates.Repo.Repo
{
    public class CartProductRepository : Repository<CartProduct>, ICartProductRepository
    {
        private readonly ApplicationDbContext DB;

        public CartProductRepository(ApplicationDbContext dB) : base(dB)
        {
            this.DB = dB;
        }

        public int Update(CartProduct cartProduct)
        {
            CartProduct toEdit = Get(cp=> cp.ID == cartProduct.ID);
            if (toEdit != null)
            {
                toEdit.Product = cartProduct.Product;
                toEdit.Quantity = cartProduct.Quantity;
                return DB.SaveChanges();
            }
            return 0;
        }
    }
}

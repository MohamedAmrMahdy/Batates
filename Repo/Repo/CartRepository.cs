using Batates.Data;
using Batates.Models;
using Batates.Repo.IRepo;

namespace Batates.Repo.Repo
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        private readonly ApplicationDbContext DB;

        public CartRepository(ApplicationDbContext dB) : base(dB)
        {
            this.DB = dB;
        }

        public int Update(Cart cart)
        {
            Cart toEdit = Get((c => c.ID == cart.ID));
            if (toEdit != null)
            {
                toEdit.ApplicationUserID = cart.ApplicationUserID;
                toEdit.Products = cart.Products;
                return DB.SaveChanges();
            }
            return 0;

        }
    }
}

using Batates.Data;
using Batates.Models;
using Batates.Repo.IRepo;

namespace Batates.Repo.Repo
{
    public class WishlistRepository : Repository<Wishlist>, IWithlistRepository
    {
        private readonly ApplicationDbContext DB;

        public WishlistRepository(ApplicationDbContext dB) : base(dB)
        {
            DB = dB;
        }
        public int Update(Wishlist wishlist)
        {
            Wishlist toEdit = Get((c => c.ID == wishlist.ID));
            if (toEdit != null)
            {
                toEdit.ApplicationUserID = wishlist.ApplicationUserID;
                toEdit.WishedProducts = wishlist.WishedProducts;
                return DB.SaveChanges();
            }
            return 0;

        }

    }
}

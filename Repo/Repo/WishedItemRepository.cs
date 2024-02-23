using Batates.Data;
using Batates.Models;
using Batates.Repo.IRepo;

namespace Batates.Repo.Repo
{
    public class WishedItemRepository: Repository<WishedItem>, IWishedItemRepository
    {
        private readonly ApplicationDbContext DB;

        public WishedItemRepository(ApplicationDbContext dB) : base(dB)
        {
            this.DB = dB;
        }

        public int Update(WishedItem wishedItem)
        {
            WishedItem toEdit = Get(cp => cp.ID == wishedItem.ID);
            if (toEdit != null)
            {
                toEdit.Product = wishedItem.Product;
                
                return DB.SaveChanges();
            }
            return 0;
        }

    }
}

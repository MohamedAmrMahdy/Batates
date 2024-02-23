using Batates.Data;
using Batates.Models;
using Batates.Repo.IRepo;

namespace Batates.Repo.Repo
{
    public class OrdersRepository : Repository<Order>, IOrdersRepository
    {
        private readonly ApplicationDbContext DB;

        public OrdersRepository(ApplicationDbContext dB) : base(dB)
        {
            DB = dB;
        }

    }
}

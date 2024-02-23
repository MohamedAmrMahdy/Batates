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

        public int Update(Order order)
        {
            Order orderFromDb = DB.Orders.FirstOrDefault(o => o.ID == order.ID);
            if(orderFromDb != null)
            {
                orderFromDb.State= order.State;
            }
            DB.Orders.Update(orderFromDb);
           return DB.SaveChanges();
        }
    }
}

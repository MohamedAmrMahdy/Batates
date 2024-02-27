using Batates.Models;

namespace Batates.Repo.IRepo
{
    public interface IOrdersRepository : IRepository<Order>
    {
        int Update(Order order);
    }
}

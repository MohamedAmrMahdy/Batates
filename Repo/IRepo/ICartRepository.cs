using Batates.Models;

namespace Batates.Repo.IRepo
{
    public interface ICartRepository :IRepository<Cart>
    {
        int Update(Cart cart);
    }
}

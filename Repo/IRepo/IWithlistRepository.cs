using Batates.Models;

namespace Batates.Repo.IRepo
{
    public interface IWithlistRepository: IRepository<Wishlist>
    {

        int Update(Wishlist wishlist);
    }
}

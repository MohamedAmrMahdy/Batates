using Batates.Models;

namespace Batates.Repo.IRepo
{
    public interface ICartProductRepository :IRepository<CartProduct>
    {
        int Update(CartProduct cartProduct);
    }
}

using Batates.Models;

namespace Batates.Repo.IRepo
{
    public interface IProductRepository : IRepository<Product> 
    {
        int Update(Product product);
    }
}

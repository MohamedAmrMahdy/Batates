using Batates.Models;

namespace Batates.Repo.IRepo
{
    public interface  ICategoryRepository : IRepository<Category>
    {
        int Update(Category category);
    }


}

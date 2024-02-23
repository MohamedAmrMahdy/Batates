using Batates.Models;

namespace Batates.Repo.IRepo
{
    public interface IWishedItemRepository : IRepository<WishedItem>
    {
        int Update(WishedItem WishedItem);
    }
}

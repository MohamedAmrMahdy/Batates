using Batates.Models;

namespace Batates.Repo.IRepo
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        int Update(Restaurant restaurant);
    }
}

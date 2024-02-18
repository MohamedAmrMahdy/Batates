using Batates.Data;
using Batates.Models;
using Batates.Repo.IRepo;
using System;

namespace Batates.Repo.Repo
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        private readonly ApplicationDbContext DB;

        public RestaurantRepository(ApplicationDbContext dB) : base(dB)
        {
            DB = dB;
        }
        public int Update(Restaurant restaurant)
        {

            Restaurant toEdit = Get((p => p.ID == restaurant.ID));
            if (toEdit != null)
            {
                toEdit.Name = restaurant.Name;
                toEdit.Description = restaurant.Description;
                toEdit.ContactNo = restaurant.ContactNo;
                toEdit.ImageURL = restaurant.ImageURL;
                toEdit.State = restaurant.State;
                return DB.SaveChanges();
            }
            else { return 0; }
        }
    }
}

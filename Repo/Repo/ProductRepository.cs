using Batates.Data;
using Batates.Repo.IRepo;
using Batates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Batates.Repo.Repo
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext DB;

        public ProductRepository(ApplicationDbContext dB):base(dB)
        {
            DB = dB;
        }
        public int Update(Product product)
        {
            //Product toEdit = DbSet.FirstOrDefault(p => p.ID == product.ID);
            Product toEdit = Get((p => p.ID == product.ID));
            if(toEdit != null)
            {
                toEdit.Name = product.Name;
                toEdit.Description = product.Description;
                toEdit.Price = product.Price;
                toEdit.ImageURL = product.ImageURL;
                toEdit.ExtraDetails = product.ExtraDetails;
                toEdit.RestaurantID = product.RestaurantID;
                return DB.SaveChanges();
            }
            else { return 0; }
        }


    }
}

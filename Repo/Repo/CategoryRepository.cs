using Batates.Data;
using Batates.Models;
using Batates.Repo.IRepo;

namespace Batates.Repo.Repo
{
    public class CategoryRepository :Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext DB;
        public CategoryRepository(ApplicationDbContext dB):base(dB) 
        {
            DB = dB;
        }

        public int Update(Category category)
        {
            Category toEdit = Get((c => c.ID == category.ID));
            if(toEdit != null)
            {
                toEdit.Name = category.Name;
                toEdit.Description = category.Description;
                toEdit.ImageURL = category.ImageURL;
               return DB.SaveChanges();
            }
            return 0;
        }
    }
}

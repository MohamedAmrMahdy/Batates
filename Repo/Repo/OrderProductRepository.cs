using Batates.Data;
using Batates.Models;
using Batates.Repo.IRepo;
using NuGet.Protocol.Core.Types;

namespace Batates.Repo.Repo
{
    public class OrderProductRepository : Repository<OrderProduct>, IOrderProductRepository
    {
        public OrderProductRepository(ApplicationDbContext dB) : base(dB)
        {
           
        }
    }
}

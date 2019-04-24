using ShopOnlineAPI.Data.Infrastructure;
using ShopOnlineAPI.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineAPI.Data.Repositories
{
    public interface IVisitorStatisticRepository : IRepository<Visitorstatistic>
    {
    }

    public class VisitorStatisticRepository : RepositoryBase<Visitorstatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}

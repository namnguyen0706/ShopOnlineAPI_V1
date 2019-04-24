using ShopOnlineAPI.Data.Infrastructure;
using ShopOnlineAPI.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineAPI.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }
    public class MenuRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}

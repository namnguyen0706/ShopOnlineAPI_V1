using ShopOnlineAPI.Data.Infrastructure;
using ShopOnlineAPI.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineAPI.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}

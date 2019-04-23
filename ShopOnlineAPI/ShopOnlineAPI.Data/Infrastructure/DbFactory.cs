using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineAPI.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopOnlineDBContext dbContext;

        public ShopOnlineDBContext Init()
        {
            return dbContext ?? (dbContext = new ShopOnlineDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}

using System;

namespace ShopOnlineAPI.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopOnlineDBContext Init();
    }
}
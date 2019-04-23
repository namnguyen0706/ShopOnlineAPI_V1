namespace ShopOnlineAPI.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
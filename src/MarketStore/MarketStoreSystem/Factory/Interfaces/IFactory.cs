namespace MarketStore.MarketStoreSystem.Factory.Interfaces
{
    public interface IFactory<TEntity>
       where TEntity : class
    {
        TEntity Create(params string[] tokens);
    }
}

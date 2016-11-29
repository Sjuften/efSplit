namespace entityFramework.App.Repositories
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        TEntity Find(int id);
        void Delete(int id);
        void Update(TEntity entity);
        bool Save();
        bool Exist(int id);
    }
}
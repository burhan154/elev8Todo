namespace elev8.EntityFramework
{
    public interface IRepository<T>
    {
        T Add(T model);
        T Update(T model);
        void Delete(T model);
        T GetById(int id);
        List<T> GetAll();
    }
}

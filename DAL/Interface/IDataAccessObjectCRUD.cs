namespace DAL.Interface
{
    public interface IDataAccessObjectCRUD<T>
    {
        T Get(int id);
        void Update(int id, T obj);
        void Insert(T obj);
        void Delete(int id);
    }
}
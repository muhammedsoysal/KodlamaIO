using KodlamaIO.Entities;

namespace KodlamaIO.DataAccess.Abstract;

public interface IGenericDal<T> where T : class
{
    List<T> GetAll();
    void Add(T entity);
    void Delete(int id);
    void Update(T entity);
}
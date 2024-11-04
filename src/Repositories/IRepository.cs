using System.Collections.Generic;
using System.Threading.Tasks;

namespace PIM_IV_Forms.Repositories;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(int id);
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(int id);
}
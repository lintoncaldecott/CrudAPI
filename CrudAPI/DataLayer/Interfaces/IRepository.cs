using System.Collections.Generic;

namespace CrudAPI.DataLayer.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T Entity);
        void Update(T entity);
        T FindById(int Id);
    }
}

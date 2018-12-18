using System.Collections.Generic;
using System.Linq;

namespace Projeto.Domain.Interfaces
{
    public interface IRepository<T> where T: class, IEntity, new()
    {
        T GetById (int id);

        IQueryable<T> ListAll ();

        void Update(T entity);

        void Insert(T entity);

        void Remove(int id);

    }
}
using Projeto.Domain.Interfaces;
using System.Collections.Generic;

namespace Projeto.Application.Interfaces
{
    public interface IServices<T> where T: class, IEntity, new()
    {
        T GetById (int id);
        
        IEnumerable<T> ListAll ();

        void Save(T entity);
               
        void Remove(int id);
    }
}
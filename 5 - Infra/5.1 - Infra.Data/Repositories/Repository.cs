using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Interfaces;
using System.Linq;
using Projeto.Infra.Configuration;

namespace Projeto.Infra.Repositories
{
    public class Repository<T>: IRepository<T> where T: class, IEntity, new()
    {
        protected readonly Context Db;
        protected readonly DbSet<T> DbSet;

        public Repository(Context context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        public T GetById (int id) 
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> ListAll () {
            return DbSet;
        }

        public void Update(T entity)
        {
            DbSet.Update(entity);
        }

        public void Insert(T entity)
        {
            DbSet.Add(entity);
        }

        public void  Remove(int id)
        {
            DbSet.Remove(this.GetById(id));
        }
    }
}
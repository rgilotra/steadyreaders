using RepositoryPattern.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DataAccess.Repository.Concrete
{
    class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        public Repository(DbContext dbContext) {
            this.Context = dbContext;
        }

        public T GetById(int id) {
            return this.Context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll() {
            return this.Context.Set<T>().ToList();
        }

        public void Add(T entity) {
            this.Context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            this.Context.Set<T>().AddRange(entities);
        }

        public void Remove(T entity)   {
            this.Context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            this.Context.Set<T>().RemoveRange(entities);
        }




    }
}

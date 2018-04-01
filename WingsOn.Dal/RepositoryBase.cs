using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WingsOn.Domain;

namespace WingsOn.Dal
{
    public class RepositoryBase<T> : IRepository<T> where T : DomainObject
    {
        protected RepositoryBase()
        {
            Repository = new List<T>();
        }

        protected List<T> Repository;

        public IEnumerable<T> GetAll()
        {
            return Repository;
        }

        public T Get(int id)
        {
            return GetAll().SingleOrDefault(a => a.Id == id);
        }

        public void Save(T element)
        {
            if (element == null)
            {
                return;
            }

            T existing = Get(element.Id);
            if (existing != null)
            {
                Repository.Remove(existing);
            }

            Repository.Add(element);
        }
    }
}

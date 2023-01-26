using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context db = new Context();

        public void Delete(T entity)
        {
            db.Remove(entity);
            db.SaveChanges();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return db.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            db.Add(entity);
            db.SaveChanges();   
        }

		public List<T> GetListAll(Expression<Func<T, bool>> filter)
		{
			return db.Set<T>().Where(filter).ToList();
		}

		public void Update(T entity)
        {
            db.Update(entity);
            db.SaveChanges();
        }
    }
}

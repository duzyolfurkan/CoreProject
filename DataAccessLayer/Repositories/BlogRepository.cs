using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void Insert(Blog blog)
        {
            using var db = new Context();
            db.Blogs.Add(blog);
            db.SaveChanges();
        }

        public void Delete(Blog blog)
        {
            using var db = new Context();
            db.Blogs.Remove(blog);
            db.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var db = new Context();
            return db.Blogs.Find(id);
        }

        public void Update(Blog blog)
        {
            using var db = new Context();
            db.Blogs.Update(blog);
            db.SaveChanges();
        }

        public List<Blog> GetListAll()
        {
            using var db = new Context();
            return db.Blogs.ToList();
        }
    }
}

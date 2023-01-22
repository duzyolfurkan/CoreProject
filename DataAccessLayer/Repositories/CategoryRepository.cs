using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context db = new Context();

        public void AddCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            db.Categories.Remove(category);
            db.SaveChanges();
        }

        public Category GetById(int id)
        {
            return db.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return db.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            db.Categories.Update(category);
            db.SaveChanges();
        }
    }
}

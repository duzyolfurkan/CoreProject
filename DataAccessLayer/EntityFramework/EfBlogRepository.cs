﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        //Eager Loading
        public List<Blog> GetListWithCategory()
        {
            using(var c = new Context())
            {
                return c.Blogs.Include(x=>x.Category).ToList();
            }
                 
        }
    }
}

using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void BlogAdd(Blog blog);
		void BlogDelete(Blog blog);
		void BlogUpdate(Blog blog);
		List<Blog> GetListAll();
		Blog GetById(int id);
		List<Blog> GetBlogListWithCategory();
		List<Blog> GetListAll(int id);
		List<Blog> GetBlogByWriter(int id);
	}
}

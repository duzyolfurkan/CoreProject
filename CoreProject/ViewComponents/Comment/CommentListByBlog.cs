using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		public IViewComponentResult Invoke(int id)
		{
			CommentManager cm = new CommentManager(new EfCommentRepository());

			var values = cm.GetListAll(id);
			return View(values);
		}
	}
}

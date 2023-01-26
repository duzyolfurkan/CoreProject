using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());

		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}

		public PartialViewResult CommentListByBlog()
		{
			return PartialView();
		}

		public PartialViewResult CommentListByBlog(int id) 
		{
			var values = cm.GetListAll(id);
			return PartialView(values);

		}
	}
}

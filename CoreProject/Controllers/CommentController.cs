using BusinessLayer.Concrate;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CoreProject.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		Context db = new Context();

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

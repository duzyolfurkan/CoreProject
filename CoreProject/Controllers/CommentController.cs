using BusinessLayer.Concrate;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;
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

		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
			comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			comment.CommentStatus = true;
			comment.BlogID = 2;
			cm.CommentAdd(comment);
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

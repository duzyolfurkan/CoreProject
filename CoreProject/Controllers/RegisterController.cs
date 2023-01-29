using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			if (ModelState.IsValid)
			{
				writer.WriterStatus = true;
				writer.WriterAbout = "Deneme Test";
				wm.WriterAdd(writer);
				return RedirectToAction("Index", "Blog");
			}

			return View();
			
		}


	}
}

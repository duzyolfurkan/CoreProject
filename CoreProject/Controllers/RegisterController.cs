using BusinessLayer.Concrate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Infrastructure;

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
			WriterValidator wv = new WriterValidator();
			ValidationResult results = wv.Validate(writer);

			if (results.IsValid)
			{

                    writer.WriterStatus = true;
                    writer.WriterAbout = "Deneme Test";
                    wm.WriterAdd(writer);
                    return RedirectToAction("Index", "Blog");
            }

			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

			return View();


		}


	}
}

using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

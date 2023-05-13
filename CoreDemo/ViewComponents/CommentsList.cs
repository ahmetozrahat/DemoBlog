using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
	public class CommentsList: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment>
			{
				new UserComment
				{
					ID = 1,
					Username = "Ahmet"
				},
				new UserComment
				{
					ID = 2,
					Username = "Betül"
				},
				new UserComment
				{
					ID = 3,
					Username = "Bilge"
				}
			};
			return View(commentValues);
		}
	}
}

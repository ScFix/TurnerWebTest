using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurnerWebTest.Entities;
using TurnerWebTest.Models;

namespace TurnerWebTest.Controllers
{
	public class TitleController : Controller
	{
		// GET: Title
		public ActionResult Index(int id)
		{
			// NOTE this was much debate to me, wether or not I should just leave this to be displayed via angulare or whether it should be displayed in a more traditional fashion.
			// I am honestly not sure, much of what I know about the Angular engine is that it has huge advantages when pulling down different bits of data dynamically making small calls. however this is not really waht I did her mostly because of the open ended nature of the design. 
			// Personally going down the route of the Angular would had to have to implent a state engine using the UI routes module, this would of taken me much more time and I finally came to the conclusion that showing a more diverse knowledge base should not hurt me, and I rather complete a something than not. 
			DescriptiveTitle title = null;

			Title result = null;
			using (var entities = new TitlesEntities())
			{
				result = (from t in entities.Titles
						  where t.TitleId == id
						  select t).FirstOrDefault();
				if (result != null)
					title = new DescriptiveTitle(result);

			}
			//Should have a better way of doing this.
			if (title == null)
			{
				throw new HttpException(404, "Item Not Found");
			}
			return View(title);
		}
	}
}
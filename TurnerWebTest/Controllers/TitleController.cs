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
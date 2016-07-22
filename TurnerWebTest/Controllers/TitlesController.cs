using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TurnerWebTest.Entities;
using TurnerWebTest.Models;

namespace TurnerWebTest.Controllers
{
	public class TitlesController : ApiController
	{

		public TitlesResult Get(string token, int skip = 0)
		{
			var result = new TitlesResult();
			var titles = new List<ReducedTitle>();

			using (var entities = new TitlesEntities())
			{
				// Note(Matthew): I have tested the fact that the StartsWith function is not case sensitive.
				// if in genearal you want an bigger pool of information that would be more of a contains it is possible however much more complicated
				// I would then need to modify the database to use a stored procedure this way there is no need for db prep 
				titles = (from t in entities.Titles
						  where t.TitleName.StartsWith(token)
						  select new ReducedTitle() { Title = t.TitleName }).ToList();
			}
			// TODO(Matthew): Remove the static number and put it in a config file that can change, or even make it part of the api, and let the client side handle it.
			result.Items = titles.Skip(skip).Take(20).ToList();
			result.TotalCount = titles.Count;

			return result;
		}
	}
}

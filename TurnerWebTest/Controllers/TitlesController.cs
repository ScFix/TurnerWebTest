using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TurnerWebTest.Entities;

namespace TurnerWebTest.Controllers
{
	public class TitlesController : ApiController
	{
		public IEnumerable<Title> Get(string token)
		{
			using (var entities = new TitlesEntities())
			{
			}
			//return tt.ToList();
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnerWebTest.Models
{
	public class TitlesResult
	{
		public IList<ReducedTitle> Items { get; set; }
		public int TotalCount { get; set; }

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TurnerWebTest.Entities;

namespace TurnerWebTest.Models
{
	public class DescriptiveTitle
	{
		//public String Description { get; set; }
		public List<Storyline> VariaousDescriptions { get; set; }
		public String Language { get; set; }
		public List<String> Genres { get; set; }
		public List<Trophies> Awards { get; set; }
		public List<String> OtherNames { get; set; }
		public List<person> Participants { get; set; }
		public string Name { get; set; }
		public DescriptiveTitle(Title result)
		{
			this.OtherNames = new List<string>();
			this.Genres = new List<string>();
			this.VariaousDescriptions = new List<Storyline>();
			this.Participants = new List<person>();
			this.Awards = new List<Trophies>();
			
			var main = result.OtherNames.Where(n => { return n.TitleNameType == "Primary"; }).First();
			this.Language = main.TitleNameLanguage;
			this.Name = main.TitleName;
			foreach (var names in result.OtherNames)
			{
				this.OtherNames.Add(names.TitleName);
			}
			foreach (var tg in result.TitleGenres)
			{
				this.Genres.Add(tg.Genre.Name);
			}
			foreach (var sl in result.StoryLines)
			{
				this.VariaousDescriptions.Add(new Storyline() { Description = sl.Description, Type = sl.Type });
			}
			foreach (var person in result.TitleParticipants)
			{
				this.Participants.Add(new Models.person() { Name = person.Participant.Name, Type = person.Participant.ParticipantType, Role = person.RoleType });
			}
			foreach (var aw in result.Awards)
			{
				this.Awards.Add(new Trophies() { Name = aw.Award1, Won = aw.AwardWon ?? false, Company = aw.AwardCompany, Year = aw.AwardYear ?? 0 });
			}
		}
	}
}
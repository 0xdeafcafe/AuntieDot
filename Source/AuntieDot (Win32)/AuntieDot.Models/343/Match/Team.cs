using System.Collections.Generic;

namespace AuntieDot.Models._343.Match
{
	public class Team
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Common.ImageUrl EmblemImageUrl { get; set; }
		public string PrimaryRGB { get; set; }
		public int PrimaryRGBA { get; set; }
		public string SecondaryRGB { get; set; }
		public int SecondaryRGBA { get; set; }
		public int Standing { get; set; }
		public int Score { get; set; }
		public int Kills { get; set; }
		public int Deaths { get; set; }
		public int Assists { get; set; }
		public int Betrayals { get; set; }
		public int Suicides { get; set; }
		public IList<Common.OverTime> DeathsOverTime { get; set; }
		public IList<Common.OverTime> KillsOverTime { get; set; }
		public IList<Common.OverTime> MedalsOverTime { get; set; }
		public int TotalMedals { get; set; }
		public IList<Common.TopMedal> MedalStats { get; set; }
	}
}

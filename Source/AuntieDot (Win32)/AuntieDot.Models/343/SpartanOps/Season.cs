using System.Collections.Generic;

namespace AuntieDot.Models._343.SpartanOps
{
	public class Season
	{
		public int Id { get; set; }
		public bool IsCurrentSeason { get; set; }
		public int CurrentEpisode { get; set; }
		public IList<Episode> Episodes { get; set; } 
	}
}

using System.Collections.Generic;

namespace AuntieDot.Models._343.SpartanOps
{
	public class Episode
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Desc { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
		public IList<Chapter> Chapters { get; set; }
	}
}

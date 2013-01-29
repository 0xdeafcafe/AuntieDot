using System.Collections.Generic;

namespace AuntieDot.Models._343.Matches
{
	public class MatchesResponse : XResponse
	{
		public int DateFidelity { get; set; }
		public IList<Game> Games { get; set; }
		public string StatusReason { get; set; }
	}
}

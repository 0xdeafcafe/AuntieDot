using System.Collections.Generic;

namespace AuntieDot.Models._343.Commendations
{
	public class CommendationsResponse : XResponse
	{
		public IList<Commendation> Commendations { get; set; }
	}
}

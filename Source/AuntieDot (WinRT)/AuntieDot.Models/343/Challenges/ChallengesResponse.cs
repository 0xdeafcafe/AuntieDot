using System;
using System.Collections.Generic;

namespace AuntieDot.Models._343.Challenges
{
	public class ChallengesResponse : XResponse
	{
		public DateTime Date { get; set; }
		public IList<Challenge> Challenges { get; set; }
		public IList<Category> Categories { get; set; }
		public int TotalCompleted { get; set; }
		public string Periods { get; set; }
	}
}

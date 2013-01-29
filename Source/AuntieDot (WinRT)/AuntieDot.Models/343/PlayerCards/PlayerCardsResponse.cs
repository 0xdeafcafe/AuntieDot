using System.Collections.Generic;

namespace AuntieDot.Models._343.PlayerCards
{
	public class PlayerCardsResponse : XResponse
	{
		public IList<PlayerCard> PlayerCards { get; set; } 
	}
}

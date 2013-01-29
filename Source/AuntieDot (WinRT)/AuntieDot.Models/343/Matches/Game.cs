using System.Collections.Generic;

namespace AuntieDot.Models._343.Matches
{
	public class Game
	{
		public int Standing { get; set; }
		public int BaseVariantId { get; set; }
		public Common.ImageUrl BaseVariantImageUrl { get; set; }
		public string VariantName { get; set; }
		public string FeaturedStatName { get; set; }
		public int FeaturedStatValue { get; set; }
		public IList<object> PromotionIds { get; set; }
		public int TotalMedals { get; set; }
		public IList<int> TopMedalIds { get; set; }
		public int MapId { get; set; }
		public Common.ImageUrl MapImageUrl { get; set; }
		public string MapVariantName { get; set; }
		public int PlayListId { get; set; }
		public string PlayListName { get; set; }
		public int PersonalScore { get; set; }
		public string Id { get; set; }
		public int ModeId { get; set; }
		public string ModeName { get; set; }
		public bool Completed { get; set; }
		public int Result { get; set; }
		public string EndDateUtc { get; set; }
	}
}

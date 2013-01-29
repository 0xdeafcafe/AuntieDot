using System;

namespace AuntieDot.Models._343.Customs
{
	public class Summary
	{
		public TimeSpan TotalDuration { get; set; }
		public int TotalKills { get; set; }
		public int TotalDeaths { get; set; }
		public int TotalGamesCompleted { get; set; }
		public int TotalGamesWon { get; set; }
		public int TotalMedals { get; set; }
		public int AveragePersonalScore { get; set; }
		public float KDRatio { get; set; }
		public int TotalGameBaseVariantMedals { get; set; }
		public FavoriteVariant FavoriteVariant { get; set; }
		public int PresentationId { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public int TotalGamesStarted { get; set; }
	}
}

using System;
using System.Collections.Generic;

namespace AuntieDot.Models._343.WarGames
{
	public class BaseGameVarient
	{
		public int TotalGames1stPlace { get; set; }
		public int TotalGamesTopHalf { get; set; }
		public int TotalGamesTopThird { get; set; }
		public string GameTypeMedalName { get; set; }
		public int TotalGameTypeMedals { get; set; }
		public int TotalAssists { get; set; }
		public int TotalHeadshots { get; set; }
		public int TotalBetrayals { get; set; }
		public int TotalSuicides { get; set; }
		public IList<Common.Damage> TotalKillsByDamageType { get; set; }
		public IList<Common.Damage> TotalDeathsByDamageType { get; set; }
		public IList<Common.Damage> TotalHeadshotsByWeapon { get; set; }
		public IList<Common.MedalStat> TotalMedalsStats { get; set; }
		public int BestPersonalScore { get; set; }
		public string BestPersonalScoreGameId { get; set; }
		public string FeaturedStatName { get; set; }
		public int BestFeaturedStatValue { get; set; }
		public string BestFeaturedStatGameId { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
		public TimeSpan TotalDuration { get; set; }
		public int TotalGamesStarted { get; set; }
		public int TotalGamesCompleted { get; set; }
		public int TotalGamesWon { get; set; }
		public int TotalMedals { get; set; }
		public int TotalKills { get; set; }
		public int TotalDeaths { get; set; }
		public int KDRatio { get; set; }
		public int AveragePersonalScore { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
	}
}

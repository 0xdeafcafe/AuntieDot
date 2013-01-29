using System.Collections.Generic;

namespace AuntieDot.Models._343.WarGames
{
	public class Map
	{
		public int MapId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
		public string ArticleId { get; set; }
		public int TotalGamesStarted { get; set; }
		public int TotalGamesCompleted { get; set; }
		public int TotalGamesWon { get; set; }
		public int TotalGamesTied { get; set; }
		public int TotalGamesLost { get; set; }
		public int TotalKills { get; set; }
		public int TotalDeaths { get; set; }
		public int TotalAssists { get; set; }
		public int TotalMedals { get; set; }
		public IList<Common.MedalStat> TotalMedalsStats { get; set; }
		public IList<Common.Damage> TotalKillsByDamageType { get; set; }
		public IList<Common.Damage> TotalDeathsByDamageType { get; set; }
		public IList<Common.Damage> TotalHeadshotsByWeapon { get; set; }
	}
}

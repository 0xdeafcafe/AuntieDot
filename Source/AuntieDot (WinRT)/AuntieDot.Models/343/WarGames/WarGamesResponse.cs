using System;
using System.Collections.Generic;

namespace AuntieDot.Models._343.WarGames
{
	public class WarGamesResponse : XResponse
	{
		public Summary Summary { get; set; }
		public int TotalGames1stPlace { get; set; }
		public int TotalGamesTopHalf { get; set; }
		public int TotalGamesTopThird { get; set; }
		public int TotalBetrayals { get; set; }
		public int TotalSuicides { get; set; }
		public BaseGameVarient GameBaseVarients { get; set; }
		public IList<Map> Maps { get; set; }
		public int DateFidelity { get; set; }
		public string ArticleId { get; set; }
		public int TotalChallengesCompleted { get; set; }
		public IList<Common.MedalStat> TotalMedalsStats { get; set; }
		public IList<int> TopMedalIds { get; set; }
		public int TotalAssists { get; set; }
		public int TotalHeadshots { get; set; }
		public IList<Common.Damage> TotalKillsByDamageType { get; set; }
		public IList<Common.Damage> TotalDeathsByDamageType { get; set; }
		public IList<Common.Damage> TotalHeadshotsByWeapon { get; set; }
		public int BestGameTotalKills { get; set; }
		public string BestGameTotalKillsGameId { get; set; }
		public int BestGameTotalMedals { get; set; }
		public string BestGameTotalMedalsGameId { get; set; }
		public IList<Common.MedalsByTier> BestGameMedalsByTier { get; set; }
		public int BestGameHeadshotTotal { get; set; }
		public string BestGameHeadshotTotalGameId { get; set; }
		public int BestGameAssassinationTotal { get; set; }
		public string BestGameAssassinationTotalGameId { get; set; }
		public int BestGameKillDistance { get; set; }
		public string BestGameKillDistanceGameId { get; set; }
		public int BestDayTotalGames { get; set; }
		public DateTime BestDayTotalGamesDay { get; set; }
		public TimeSpan BestDayDuration { get; set; }
		public DateTime BestDayDurationDay { get; set; }
		public int BestDayTotalKills { get; set; }
		public DateTime BestDayTotalKillsDay { get; set; }
		public int BestDayTotalMedals { get; set; }
		public DateTime BestDayTotalMedalsDay { get; set; }
		public IList<Common.MedalsByClass> BestDayMedalsByClass { get; set; }
		public IList<Common.MedalsByTier> BestDayMedalsByTier { get; set; }
		public int BestDayHeadshotTotal { get; set; }
		public DateTime BestDayHeadshotTotalDay { get; set; }
		public int BestDayAssassinationTotal { get; set; }
		public DateTime BestDayAssassinationTotalDay { get; set; }
	}
}

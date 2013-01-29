using System;
using System.Collections.Generic;

namespace AuntieDot.Models._343.SpartanOps
{
	public class Chapter
	{
		public int Id { get; set; }
		public int Number { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
		public int TotalGamesStarted { get; set; }
		public int TotalGamesCompleted { get; set; }
		public TimeSpan TotalDuration { get; set; }
		public int TotalMedals { get; set; }
		public IList<Common.MedalStat> TotalMedalsStats { get; set; }
		public int TotalKills { get; set; }
		public int TotalDeaths { get; set; }
		public int TotalAssists { get; set; }
		public IList<Common.Damage> TotalKillsByDamageType { get; set; }
		public IList<Common.Damage> TotalDeathsByDamageType { get; set; }
		public IList<Common.Damage> TotalHeadshotsByWeapon { get; set; }
		public IList<Common.EnemyKill> TotalKillsOfEnemy { get; set; }
		public IList<Common.EnemyKill> TotalDeathsByEnemy { get; set; }
		public IList<Common.DifficultyCompletion> SinglePlayerBeat { get; set; }
		public IList<Common.DifficultyCompletion> CoopBeat { get; set; }
		public IList<Common.DifficultyCompletion> SinglePlayerBeatNoDeaths { get; set; }
		public IList<Common.DifficultyCompletion> CoopBeatNoDeaths { get; set; }
		public TimeSpan BestGameDuration { get; set; }
		public string BestGameDurationGameId { get; set; }
		public DateTime FirstCompletedSinglePlayer { get; set; }
		public DateTime FirstCompletedCoop { get; set; }
		public IList<Common.PlayerDurations> BestSinglePlayerDurations { get; set; }
		public IList<Common.PlayerDurations> BestCoopDurations { get; set; }
	}
}

using System;
using System.Collections.Generic;

namespace AuntieDot.Models._343.Campaign
{
	public class Map
	{
		public int Mission { get; set; }
		public IList<Common.DifficultyCompletion> SinglePlayerBeatByDifficulty { get; set; }
		public IList<Common.DifficultyCompletion> CoopBeatByDifficulty { get; set; }
		public IList<Common.DifficultyCompletion> SinglePlayerBeatDASO { get; set; }
		public IList<Common.DifficultyCompletion> CoopBeatDASO { get; set; }
		public IList<Common.DifficultyCompletion> SinglePlayerBeatNoDeaths { get; set; }
		public IList<Common.DifficultyCompletion> CoopBeatNoDeaths { get; set; }
		public IList<Common.EnemyKill> TotalKillsOfEnemy { get; set; }
		public IList<Common.EnemyKill> TotalDeathsByEnemy { get; set; }
		public TimeSpan BestGameCompletionDuration { get; set; }
		public string BestGameCompletionDurationGameId { get; set; }
		public TimeSpan BestSinglePlayerDurationLegendary { get; set; }
		public string BestSinglePlayerDurationLegendaryGameId { get; set; }
		public TimeSpan BestSinglePlayerDurationHeroic { get; set; }
		public string BestSinglePlayerDurationHeroicGameId { get; set; }
		public TimeSpan BestSinglePlayerDurationNormal { get; set; }
		public string BestSinglePlayerDurationNormalGameId { get; set; }
		public TimeSpan BestSinglePlayerDurationEasy { get; set; }
		public string BestSinglePlayerDurationEasyGameId { get; set; }
		public TimeSpan BestCoopDurationLegendary { get; set; }
		public string BestCoopDurationLegendaryGameId { get; set; }
		public TimeSpan BestCoopDurationHeroic { get; set; }
		public string BestCoopDurationHeroicGameId { get; set; }
		public TimeSpan BestCoopDurationNormal { get; set; }
		public string BestCoopDurationNormalGameId { get; set; }
		public TimeSpan BestCoopDurationEasy { get; set; }
		public string BestCoopDurationEasyGameId { get; set; }
		public int BestSinglePlayerScore { get; set; }
		public string BestSinglePlayerScoreGameId { get; set; }
		public int BestCoopScore { get; set; }
		public string BestCoopScoreGameId { get; set; }
		public DateTime FirstCompletedSinglePlayer { get; set; }
		public DateTime FirstCompletedCoop { get; set; }
		public TimeSpan TotalDuration { get; set; }
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
		public IList<object> TotalMedalsStats { get; set; }
		public IList<Common.Damage> TotalKillsByDamageType { get; set; }
		public IList<Common.Damage> TotalDeathsByDamageType { get; set; }
		public IList<Common.Damage> TotalHeadshotsByWeapon { get; set; }
	}
}

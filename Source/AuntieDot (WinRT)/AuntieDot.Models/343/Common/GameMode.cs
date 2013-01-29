using System.Collections.Generic;

namespace AuntieDot.Models._343.Common
{
	public class GameMode
	{
		public string TotalDuration { get; set; }
		public int TotalKills { get; set; }
		public int TotalDeaths { get; set; }
		public IList<DifficultyLevel> DifficultyLevels { get; set; }
		public IList<MissionData> SinglePlayerMissions { get; set; }
		public IList<MissionData> CoopMissions { get; set; }
		public int TotalTerminalsVisited { get; set; }
		public long NarrativeFlags { get; set; }
		public object SinglePlayerDASO { get; set; }
		public object SinglePlayerDifficulty { get; set; }
		public object CoopDASO { get; set; }
		public object CoopDifficulty { get; set; }
		public int PresentationId { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public int TotalGamesStarted { get; set; }
		public int? TotalSinglePlayerMissionsCompleted { get; set; }
		public int? TotalCoopMissionsCompleted { get; set; }
		public int? TotalMissionsPossible { get; set; }
		public int? TotalMedals { get; set; }
		public int? TotalGamesWon { get; set; }
		public int? TotalGamesCompleted { get; set; }
		public int? AveragePersonalScore { get; set; }
		public double? KDRatio { get; set; }
		public int? TotalGameBaseVariantMedals { get; set; }
		public FavoriteVariant FavoriteVariant { get; set; }
	}
}

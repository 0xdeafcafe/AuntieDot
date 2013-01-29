using System;
using System.Collections.Generic;

namespace AuntieDot.Models._343.Campaign
{
	public class Summary
	{
		public TimeSpan TotalDuration { get; set; }
		public int TotalKills { get; set; }
		public int TotalDeaths { get; set; }
		public IList<Common.DifficultyLevel> DifficultyLevels { get; set; }
		public IList<Common.MissionData> SinglePlayerMissions { get; set; }
		public IList<Common.MissionData> CoopMissions { get; set; }
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
	}
}

using System;

namespace AuntieDot.Models._343.SpartanOps
{
	public class Summary
	{
		public TimeSpan TotalDuration { get; set; }
		public int TotalDeaths { get; set; }
		public int TotalSinglePlayerMissionsCompleted { get; set; }
		public int TotalCoopMissionsCompleted { get; set; }
		public int TotalMissionsPossible { get; set; }
		public int TotalMedals { get; set; }
		public int TotalGamesWon { get; set; }
		public int TotalKills { get; set; }
		public int PresentationId { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public int TotalGamesStarted { get; set; }
	}
}

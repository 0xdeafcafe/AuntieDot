using System.Collections.Generic;

namespace AuntieDot.Models._343.Match
{
	public class Player
	{
		public IList<Common.OverTime> DeathsOverTime { get; set; }
		public IList<Common.OverTime> KillsOverTime { get; set; }
		public IList<Common.OverTime> MedalsOverTime { get; set; }
		public IList<Common.TopMedal> MedalStats { get; set; }
		public IList<Common.Damage> DamageTypeStats { get; set; }
		public IList<object> EnemyStats { get; set; }
		public int TeamId { get; set; }
		public bool IsCompleted { get; set; }
		public string Servicetag { get; set; }
		public bool IsGuest { get; set; }
		public bool JoinedInProgress { get; set; }
		public int Standing { get; set; }
		public int Result { get; set; }
		public int PersonalScore { get; set; }
		public string FeaturedStatName { get; set; }
		public int FeaturedStatValue { get; set; }
		public int StandingInTeam { get; set; }
		public int Kills { get; set; }
		public int Deaths { get; set; }
		public int Assists { get; set; }
		public int Headshots { get; set; }
		public int Betrayals { get; set; }
		public int Suicides { get; set; }
		public string KilledMostGamertag { get; set; }
		public int KilledMostCount { get; set; }
		public string KilledByMostGamertag { get; set; }
		public int KilledByMostCount { get; set; }
		public int RankId { get; set; }
		public string RankName { get; set; }
		public Common.ImageUrl RankUrl { get; set; }
		public Common.ImageUrl EmblemImageUrl { get; set; }
		public string FirstPlayedUtc { get; set; }
		public string LastPlayedUtc { get; set; }
		public double AverageDeathDistance { get; set; }
		public double AverageKillDistance { get; set; }
		public int TotalMedals { get; set; }
		public int TotalKillMedals { get; set; }
		public int TotalBonusMedals { get; set; }
		public int TotalAssistMedals { get; set; }
		public int TotalSpreeMedals { get; set; }
		public int TotalModeMedals { get; set; }
		public IList<int> TopMedalIds { get; set; }
		public string Gamertag { get; set; }
	}
}

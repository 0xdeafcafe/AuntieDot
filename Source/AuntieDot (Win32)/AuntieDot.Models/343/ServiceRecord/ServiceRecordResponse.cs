using System;
using System.Collections.Generic;

namespace AuntieDot.Models._343.ServiceRecord
{
	public class ServiceRecordResponse : XResponse
	{
		public int DateFidelity { get; set; }
		public string LastPlayedUtc { get; set; }
		public string FirstPlayedUtc { get; set; }
		public int SpartanPoints { get; set; }
		public int TotalGamesStarted { get; set; }
		public int TotalMedalsEarned { get; set; }
		public string TotalGameplay { get; set; }
		public int TotalChallengesCompleted { get; set; }
		public IList<Promotion> Promotions { get; set; }
		public int TotalLoadoutItemsPurchased { get; set; }
		public double TotalCommendationProgress { get; set; }
		public IList<SkillRank> SkillRanks { get; set; } 
		public string Gamertag { get; set; }
		public string ServiceTag { get; set; }
		public Common.ImageUrl EmblemImageUrl { get; set; }
		public Common.ImageUrl BackgroundImageUrl { get; set; }
		public int FavoriteWeaponId { get; set; }
		public string FavoriteWeaponName { get; set; }
		public string FavoriteWeaponDescription { get; set; }
		public Common.ImageUrl FavoriteWeaponImageUrl { get; set; }
		public int FavoriteWeaponTotalKills { get; set; }
		public int RankId { get; set; }
		public string RankName { get; set; }
		public Common.ImageUrl RankImageUrl { get; set; }
		public int RankStartXP { get; set; }
		public Int64 NextRankStartXP { get; set; }
		public int XP { get; set; }
		public int NextRankId { get; set; }
		public string NextRankName { get; set; }
		public Common.ImageUrl NextRankImageUrl { get; set; }
		public IList<Common.TopMedal> TopMedals { get; set; }
		public IList<Common.Specialization> Specializations { get; set; }
		public IList<Common.GameMode> GameModes { get; set; }
		public string StatusReason { get; set; }
	}
}

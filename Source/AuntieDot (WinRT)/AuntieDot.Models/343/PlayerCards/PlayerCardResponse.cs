using System.Collections.Generic;

namespace AuntieDot.Models._343.PlayerCards
{
    public class PlayerCardResponse : XResponse
	{
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
        public int NextRankStartXP { get; set; }
        public int XP { get; set; }
        public int NextRankId { get; set; }
        public string NextRankName { get; set; }
        public Common.ImageUrl NextRankImageUrl { get; set; }
        public IList<Common.TopMedal> TopMedals { get; set; }
        public IList<Common.Specialization> Specializations { get; set; }
        public IList<Common.GameMode> GameModes { get; set; }
	}
}

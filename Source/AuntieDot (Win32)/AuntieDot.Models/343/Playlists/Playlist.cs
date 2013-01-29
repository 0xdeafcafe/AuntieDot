using System.Collections.Generic;

namespace AuntieDot.Models._343.Playlists
{
	public class Playlist
	{
		public int Id { get; set; }
		public bool IsCurrent { get; set; }
		public int PopulationCount { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int ModeId { get; set; }
		public string ModeName { get; set; }
		public int MaxPartySize { get; set; }
		public int MaxLocalPlayers { get; set; }
		public bool IsFreeForAll { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
		public IList<Common.GameVariant> GameVariants { get; set; }
		public IList<Common.MapVariant> MapVariants { get; set; }
	}
}

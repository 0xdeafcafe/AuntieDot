using System;
using System.Collections.Generic;

namespace AuntieDot.Models._343.Match
{
	public class Game
	{
		public TimeSpan Duration { get; set; }
		public int TotalPlayers { get; set; }
		public IList<Player> Players { get; set; }
		public IList<Team> Teams { get; set; }
		public int MapId { get; set; }
		public string MapName { get; set; }
		public Common.ImageUrl MapImageUrl { get; set; }
		public string MapVariantName { get; set; }
		public int PlaylistId { get; set; }
		public string PlaylistName { get; set; }
		public int GameBaseVariantId { get; set; }
		public string GameBaseVariantName { get; set; }
		public string GameVariantName { get; set; }
		public string Id { get; set; }
		public int ModeId { get; set; }
		public string ModeName { get; set; }
		public bool Completed { get; set; }
		public int Result { get; set; }
		public DateTime EndDateUtc { get; set; }
	}
}

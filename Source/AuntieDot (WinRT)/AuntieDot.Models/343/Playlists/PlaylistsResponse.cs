using System.Collections.Generic;

namespace AuntieDot.Models._343.Playlists
{
	public class PlaylistsResponse : XResponse
	{
		public IList<Playlist> Playlists { get; set; } 
	}
}

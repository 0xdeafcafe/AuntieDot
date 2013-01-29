using MySql.Data.MySqlClient;
using System;

namespace AuntieDot.UI.Web.Connector
{
	public class PlayersCache
	{
		public static string GetPlayerData(string gamertag)
		{
			var query = new MySqlCommand("SELECT * FROM `cached_players` WHERE (`player_name`= @player_name) LIMIT 0, 1;");
			query.Parameters.AddWithValue("@player_name", gamertag.Trim().ToLower());

			var sql = MySqlConnector.RunSQLSelectQuery(query);

			if (sql.Count == 0)
				return null;

			// return dat services list, bro
			var result = new DataModels.CachedPlayer()
			{
				Expires = DateTime.Parse(sql[0][0]),
				JsonCache = sql[0][1],
				PlayerName = sql[0][2]
			};

			return result.Expires.Ticks < DateTime.Now.Ticks
						? null
						: result.JsonCache;
		}
		public static void SetPlayerData(string playerData, string gamertag)
		{
			var playerDataModel = new DataModels.CachedPlayer()
			{
				Expires = DateTime.Now.AddHours(3),
				JsonCache = playerData,
				PlayerName = gamertag.Trim().ToLower()
			};

			// TRUNCATE TABLE `cached_players`
			// INSERT INTO `cached_players` 

			// Delete Row in Table
			var query = new MySqlCommand
			{
				CommandText = @"DELETE FROM `cached_players` WHERE `player_name` = @player_name"
			};
			query.Parameters.AddWithValue("@player_name", playerDataModel.PlayerName);
			MySqlConnector.RunSQLUpdateQuery(query);

			// Add new PlayerData
			query = new MySqlCommand
			{
				CommandText = @"INSERT INTO `cached_players`
(
`expires`, 
`json_cache`, 
`player_name`
)
VALUES
(
@expires, 
@json_cache, 
@player_name
);
"
			};

			query.Parameters.AddWithValue("@expires", playerDataModel.Expires);
			query.Parameters.AddWithValue("@json_cache", playerDataModel.JsonCache);
			query.Parameters.AddWithValue("@player_name", playerDataModel.PlayerName);
			MySqlConnector.RunSQLUpdateQuery(query);
		}
	}
}
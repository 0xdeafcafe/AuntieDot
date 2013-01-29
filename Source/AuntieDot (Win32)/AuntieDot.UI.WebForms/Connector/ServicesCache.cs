using MySql.Data.MySqlClient;
using System;

namespace AuntieDot.UI.Web.Connector
{
	public static class ServicesCache
	{
		public static string GetServicesList()
		{
			var query = new MySqlCommand("SELECT * FROM `cached_services` LIMIT 0, 1;");

			var sql = MySqlConnector.RunSQLSelectQuery(query);

			if (sql.Count == 0)
				return null;

			// return dat services list, bro
			var result = new DataModels.CachedService
					            {
						            Expires = DateTime.Parse(sql[0][0]),
						            JsonCache = sql[0][1]
					            };

			return result.Expires.Ticks < DateTime.Now.Ticks
					    ? null
					    : result.JsonCache;
		}
		public static void SetServicesList(string services)
		{
			var servicesData = new DataModels.CachedService
				                   {
									   Expires = DateTime.Now.AddDays(1),
									   JsonCache = services
				                   };

			// TRUNCATE TABLE `cached_services`
			// INSERT INTO `cached_services` 

			// Clear Table
			var query = new MySqlCommand
				            {
								CommandText = @"TRUNCATE TABLE `cached_services`"
				            };
			MySqlConnector.RunSQLUpdateQuery(query);

			// Add new Service List
			query = new MySqlCommand
				        {
							CommandText = @"INSERT INTO `cached_services`
(
`expires`, 
`json_cache`
)
VALUES
(
@expires, 
@json_cache
);
"
						};

			query.Parameters.AddWithValue("@expires", servicesData.Expires);
			query.Parameters.AddWithValue("@json_cache", servicesData.JsonCache);
			MySqlConnector.RunSQLUpdateQuery(query);
		}
	}
}
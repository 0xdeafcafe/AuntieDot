using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace AuntieDot.UI.Web.Connector
{
	public class MySqlConnector
	{
		/// <summary>
		/// Run an SQL query on the server
		/// </summary>
		/// <param name="query">The MySQL Command to be executed</param>
		/// <param name="readOnly">Is the connection ReadOnly</param>
		/// <returns>List of all row's.</returns>
		public static IList<IList<string>> RunSQLSelectQuery(MySqlCommand query)
		{
			var cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings[ConfigurationManager.AppSettings["DatabaseType"]].ConnectionString);
			var adapter = new MySqlDataAdapter();

			// Connect to News Database and get recent article
			var cmd = query;
			cmd.Connection = cnx;
			MySqlDataReader Reader;
			cnx.Open();
			Reader = cmd.ExecuteReader();

			var thisTable = new List<IList<string>>();

			while (Reader.Read())
			{
				var thisRow = new List<string>();

				for (var c = 0; c < Reader.FieldCount; c++)
					thisRow.Add(Reader.GetValue(c).ToString());

				thisTable.Add(thisRow);
			}
			Reader.Close();

			cnx.Close();

			return thisTable;
		}
		public static int RunSQLUpdateQuery(MySqlCommand query)
		{
			try
			{
				var cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings[ConfigurationManager.AppSettings["DatabaseType"]].ConnectionString);

				// Connect to News Database and get recent article
				query.Connection = cnx;
				cnx.Open();
				MySqlDataReader Reader;
				Reader = query.ExecuteReader();
				cnx.Close();

				return 1;
			}
			catch
			{
				return 2;
			}
		}

		/// <summary>
		/// Parses test from a MySQL Query to be HTML Compliant
		/// </summary>
		/// <param name="input">Dat input string</param>
		/// <returns>HTML Compliant Output String</returns>
		public static string MySQLParseBody(string input)
		{
			var output = input;

			// Do NewLines
			output = output.Replace("\r\n", "<br />");

			return output;
		}
	}
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using DataLayer.Entities;

namespace DataLayer
{
	/// <summary>
	/// class used to store parameters of Database used by rest of the system
	/// </summary>
	public static class TsDbContext
	{
		//string for connecting to DB - Data Source is adress of Db server, Initial catalog is DB to connect to UserId and Password are optional
		public static string ConnectionString { get; }= GetString();

		private static string GetString()
		{
			using (StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @".\SetUp\Settings.txt")))
			{
				var builder = new StringBuilder();
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					string[] values = line.Split('^');
					switch (values[0])
					{
						case "Database Link":
							builder.Append("Data Source=" + values[1].Normalize() + ";");
							break;
						case "Database Name":
							builder.Append("Initial Catalog=" + values[1].Normalize() + ";");
							break;
						case "User Id":
							builder.Append("User Id=" + values[1] + ";");
							break;
						case "Password":
							builder.Append("Password=" + values[1] + ";");
							break;
					}
				}
				return builder.ToString();
			}
		}

		//sql string for creating of db, not used right now since system is made to have database already set up
		public static string CreateDbSqlString = String.Empty;

		
	}

	public enum TableNames
	{
		Tasks,
		Prerequisities,
		Users
	};
}
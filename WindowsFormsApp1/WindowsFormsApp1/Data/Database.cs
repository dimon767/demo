using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Data
{
	public static class Database
	{
		public static SqlConnection CreateConnection()
		{
			var connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=dimas;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True"; ;
			if (string.IsNullOrWhiteSpace(connectionString))
			{
				throw new InvalidOperationException("Строка подключения DbConnection не найдена в App.config.");
			}
			return new SqlConnection(connectionString);
		}

		public static DataTable ExecuteTable(string sql, Action<SqlParameterCollection> bind = null)
		{
			using (var connection = CreateConnection())
			using (var command = new SqlCommand(sql, connection))
			using (var adapter = new SqlDataAdapter(command))
			{
				if (bind != null)
				{
					bind(command.Parameters);
				}
				var table = new DataTable();
				connection.Open();
				adapter.Fill(table);
				return table;
			}
		}

		public static int ExecuteNonQuery(string sql, Action<SqlParameterCollection> bind)
		{
			using (var connection = CreateConnection())
			using (var command = new SqlCommand(sql, connection))
			{
				bind?.Invoke(command.Parameters);
				connection.Open();
				return command.ExecuteNonQuery();
			}
		}

		public static object ExecuteScalar(string sql, Action<SqlParameterCollection> bind)
		{
			using (var connection = CreateConnection())
			using (var command = new SqlCommand(sql, connection))
			{
				bind?.Invoke(command.Parameters);
				connection.Open();
				return command.ExecuteScalar();
			}
		}
	}
}



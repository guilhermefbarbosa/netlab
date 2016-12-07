using System;
using Npgsql;

namespace PostgresTest {
	class MainClass {
		public static void Main(string[] args) {
			// Connect to a PostgreSQL database
			NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=root;Password=123456;Database=xdr;Port=5431;CommandTimeout=60;");
			conn.Open();

			// Define a query returning a single row result set
			NpgsqlCommand command = new NpgsqlCommand("select * from GPRS where GPRS.SERVED_MSISDN = '*'", conn);

			// Execute the query and obtain a result set
			NpgsqlDataReader dr = command.ExecuteReader();

			// Output rows
			while (dr.Read())
				Console.Write("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9} \n", dr[0], dr[1], dr[2], dr[3],
				             dr[4],dr[5],dr[6],dr[7],dr[8],dr[9]);

			conn.Close();
		}
	}
}
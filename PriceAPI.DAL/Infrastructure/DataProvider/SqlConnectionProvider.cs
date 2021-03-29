using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PriceAPI.DAL.Infrastructure.DataProvider
{
    internal static class SqlConnectionProvider
    {
        internal static SqlConnection GetConnection(string connectionString)
        {
            var conn = new SqlConnection(connectionString);
            conn.Open();

            return conn;
        }

        internal static async Task<SqlConnection> GetConnectionAsync(string connectionString)
        {
            var conn = new SqlConnection(connectionString);
            await conn.OpenAsync();

            return conn;
        }
    }
}

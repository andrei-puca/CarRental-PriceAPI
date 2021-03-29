using Microsoft.Extensions.Options;
using PriceAPI.Common.SettingsOptions;
using PriceAPI.DAL.Infrastructure.DataProvider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PriceAPI.DAL.DataService
{
    public class BaseDataService
    {
        private readonly DatabaseOptions _options;

        public BaseDataService(IOptions<DatabaseOptions> databaseOptions)
        {
            _options = databaseOptions.Value;
        }

        protected SqlConnection GetOpenConnection()
        {

            return SqlConnectionProvider.GetConnection(_options.ConnectionString);
        }

        protected async Task<SqlConnection> GetOpenConnectionAsync()
        {

            return await SqlConnectionProvider.GetConnectionAsync(_options.ConnectionString);
        }

    }
}

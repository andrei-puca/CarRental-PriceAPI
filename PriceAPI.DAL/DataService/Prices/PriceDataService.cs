using Dapper;
using Microsoft.Extensions.Options;
using PriceAPI.Common.SettingsOptions;
using PriceAPI.DAL.Entities.Prices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PriceAPI.DAL.DataService.Prices
{
    public class PriceDataService : BaseDataService, IPriceDataService
    {

        private const string SpReadAll = "dbo.GetAllPrices";
        private const string SpCalculateTotalPrice = "dbo.CalculateTotalPrice";


        public PriceDataService(IOptions<DatabaseOptions> databaseOptions)
            : base(databaseOptions)
        {
        }

        public async Task<IEnumerable<PriceItem>> GetAllAsync()
        {
            using (var conn = await GetOpenConnectionAsync())
            {
                return await conn.QueryAsync<PriceItem>(

                    sql: SpReadAll,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<PriceItem>> GetTotalPrice(Guid carId, DateTime startDate, DateTime endDate)
        {
            using (var conn = await GetOpenConnectionAsync())
            {
                return await conn.QueryAsync<PriceItem>(
                     param: new
                     {
                         carId = carId,
                         startDate = startDate,
                         endDate = endDate
                     },
                    sql: SpCalculateTotalPrice,
                    commandType: CommandType.StoredProcedure);
            }

        }



    }
}

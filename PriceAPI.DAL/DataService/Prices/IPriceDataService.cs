using PriceAPI.DAL.Entities.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceAPI.DAL.DataService.Prices
{
    public interface IPriceDataService
    {
        Task<IEnumerable<PriceItem>> GetAllAsync();

        Task<IEnumerable<PriceItem>> GetTotalPrice(Guid carId, DateTime startDate, DateTime endDate);
    }
}

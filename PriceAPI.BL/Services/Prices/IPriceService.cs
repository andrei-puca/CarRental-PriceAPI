using Microsoft.AspNetCore.Mvc;
using PriceAPI.BL.Models.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceAPI.BL.Services.Prices
{
    public interface IPriceService
    {
        Task<IEnumerable<PriceModel>> GetTotalPrice(Guid carId, DateTime startDate, DateTime endDate);
    }
}

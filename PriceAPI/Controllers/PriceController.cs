using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PriceAPI.BL.Models.Prices;
using PriceAPI.BL.Services.Prices;

namespace PriceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PriceController : ControllerBase
    {
        private readonly IPriceService _priceService;

        public PriceController(IPriceService priceService)
        {
            _priceService = priceService;
        }


        //[HttpGet]
        //[Route("GetAllPrices")]
        ///// <summary>
        ///// Get a list of items
        ///// </summary>
        ///// <returns>List with TodoModels</returns>
        //public virtual async Task<IEnumerable<PriceModel>> GetAllPrices()
        //{

        //    return await _priceService.GetAllAsync();
        //}

        [HttpGet]
        [Route("GetPriceByCarId/{carId}/{startDate}/{endDate}")]
        /// <summary>
        /// Get a list of items
        /// </summary>
        /// <returns>List with TodoModels</returns>
        public virtual async Task<IEnumerable<PriceModel>> GetPriceByCarId(Guid carId, DateTime startDate, DateTime endDate)
        {
            return await _priceService.GetTotalPrice(carId, startDate, endDate);
            
        }
    }
}
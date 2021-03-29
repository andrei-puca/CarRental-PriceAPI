using AutoMapper;
using PriceAPI.BL.Models.Prices;
using PriceAPI.DAL.DataService.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceAPI.BL.Services.Prices
{
    public class PriceService : IPriceService
    {
        private readonly IMapper _mapper;
        private readonly IPriceDataService _priceDataService;

        public PriceService(IMapper mapper, IPriceDataService priceDataService)
        {
            _mapper = mapper;
            _priceDataService = priceDataService;
        }

        public async Task<IEnumerable<PriceModel>> GetAllAsync()
        {
            var prices = await _priceDataService.GetAllAsync();
            return _mapper.Map<IEnumerable<PriceModel>>(prices);
        }

        public async Task<IEnumerable<PriceModel>> GetTotalPrice(Guid carId, DateTime startDate, DateTime endDate)
        {
            var prices = await _priceDataService.GetTotalPrice(carId, startDate, endDate);
            return _mapper.Map<IEnumerable<PriceModel>>(prices);
        }
    }
}

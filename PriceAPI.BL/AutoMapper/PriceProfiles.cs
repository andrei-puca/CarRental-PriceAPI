using AutoMapper;
using PriceAPI.BL.Models.Prices;
using PriceAPI.DAL.Entities.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceAPI.BL.AutoMapper
{
    public class PriceProfiles : Profile
    {
        public PriceProfiles()
        {
            CreateMap<PriceItem, PriceModel>().ReverseMap();
        }

    }
}

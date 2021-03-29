using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceAPI.BL.Models.Prices
{
    public class PriceModel
    {
        public Guid Id { get; set; }

        public Guid CarId { get; set; }

        public int Price { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceAPI.DAL.Entities.Prices
{
    public class PriceItem
    {
        public Guid Id { get; set; }

        public Guid CarId { get; set; }

        public int Price { get; set; }

    }
}

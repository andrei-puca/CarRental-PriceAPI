using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceAPI.DAL.Entities.Reservation
{
    public class ReservationItem
    {
        public Guid carId { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

    }
}

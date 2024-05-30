using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTrackingApplication.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Price { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
    }
}

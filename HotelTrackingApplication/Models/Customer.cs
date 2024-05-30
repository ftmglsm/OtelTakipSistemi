using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTrackingApplication.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public long Tc { get; set; }

        [StringLength(32)]
        public string Name { get; set; }
        [StringLength(32)]
        public string Lastname { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}

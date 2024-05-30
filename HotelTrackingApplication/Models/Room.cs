using System.ComponentModel.DataAnnotations;

namespace HotelTrackingApplication.Models
{
    public class Room
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
    }
}

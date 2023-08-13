namespace Taht.Core
{
    public class Reservation : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;

        public DateTime BookingTime { get; set; }
        public int GuestCount { get; set; }

        public ICollection<Review> Reviews { get; set; } = null!;
    }
}

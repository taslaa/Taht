namespace Taht.Core
{
    public class Reservation : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;

        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = null!;

        public DateTime ReservationDate { get; set; }
        public int GuestCount { get; set; }
        public ReservationStatus Status { get; set; }

        public ICollection<Review> Reviews { get; set; } = null!;
    }
}

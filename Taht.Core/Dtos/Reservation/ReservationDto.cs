namespace Taht.Core
{
    public class ReservationDto : BaseDto
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;

        public string AppointmentTime { get; set; } = null!;
        public DateTime ReservationDate { get; set; }
        public int GuestCount { get; set; }
        public ReservationStatus Status { get; set; }
    }
}

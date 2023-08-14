namespace Taht.Core
{
    public class ReservationUpsertDto : BaseUpsertDto
    {
        public int UserId { get; set; }

        public int ServiceId { get; set; }

        public DateTime BookingTime { get; set; }
        public int GuestCount { get; set; }
        public ReservationStatus Status { get; set; }
    }
}

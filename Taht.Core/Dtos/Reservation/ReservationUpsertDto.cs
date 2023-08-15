namespace Taht.Core
{
    public class ReservationUpsertDto : BaseUpsertDto
    {
        public int UserId { get; set; }

        public int ServiceId { get; set; }

        public int AppointmentId { get; set; }

        public DateTime ReservationDate { get; set; }
        public int GuestCount { get; set; }
        public ReservationStatus Status { get; set; }
    }
}

namespace Taht.Core
{
    public class ReservationUpsertDto : BaseUpsertDto
    {
        public float? ReviewRating { get; set; }
        public string? ReviewComment { get; set; }

        public int UserId { get; set; }

        public int ServiceId { get; set; }

        public DateTime BookingTime { get; set; }
        public int GuestCount { get; set; }
    }
}

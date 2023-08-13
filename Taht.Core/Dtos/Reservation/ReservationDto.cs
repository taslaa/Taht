namespace Taht.Core
{
    public class ReservationDto : BaseDto
    {
        public float? ReviewRating { get; set; }
        public string? ReviewComment { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;

        public DateTime BookingTime { get; set; }
        public int GuestCount { get; set; }
    }
}

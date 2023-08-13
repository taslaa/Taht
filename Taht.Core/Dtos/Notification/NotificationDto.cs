namespace Taht.Core
{
    public class NotificationDto : BaseDto
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; } = null!;

        public string Message { get; set; } = null!;
    }
}

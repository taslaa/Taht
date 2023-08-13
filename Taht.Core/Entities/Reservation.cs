namespace Taht.Core
{
    public class Reservation : BaseEntity
    {
        public float? ReviewRating { get; set; }
        public string? ReviewComment { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;

        public DateTime BookingTime { get; set; }
        public int GuestCount { get; set; }

        public ICollection<Notification> Notifications { get; set; } = null!;
    }
}

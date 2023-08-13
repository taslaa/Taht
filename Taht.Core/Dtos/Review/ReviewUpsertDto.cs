namespace Taht.Core
{
    public class ReviewUpsertDto : BaseUpsertDto
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; } = null!;

        public float ReviewRating { get; set; }
        public string? ReviewComment { get; set; }
        public bool IsAnonymous { get; set; }
    }
}

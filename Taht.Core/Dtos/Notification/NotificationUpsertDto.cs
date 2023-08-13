namespace Taht.Core
{
    public class NotificationUpsertDto : BaseUpsertDto
    {
        public int UserId { get; set; }

        public int ReservationId { get; set; }

        public string Message { get; set; } = null!;
    }
}

namespace Taht.Core
{
    public class ReviewUpsertDto : BaseUpsertDto
    {
        public int UserId { get; set; }

        public float ReviewRating { get; set; }
        public string? ReviewComment { get; set; }
        public bool IsAnonymous { get; set; }
    }
}

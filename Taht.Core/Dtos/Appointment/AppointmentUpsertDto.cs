namespace Taht.Core
{
    public class AppointmentUpsertDto : BaseUpsertDto
    {
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTime { get; set; } = null!;
        public bool IsBooked { get; set; }
    }
}

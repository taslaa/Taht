namespace Taht.Core
{
    public class AppointmentDto : BaseDto
    {
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTime { get; set; } = null!;
        public bool IsBooked { get; set; }
    }
}

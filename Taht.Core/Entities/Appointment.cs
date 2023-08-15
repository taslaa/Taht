namespace Taht.Core
{
    public class Appointment : BaseEntity
    {
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTime { get; set; } = null!;
        public bool IsBooked { get; set; }

        public Reservation Reservation { get; set; } = null!;
    }
}
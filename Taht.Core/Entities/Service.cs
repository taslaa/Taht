namespace Taht.Core
{
    public class Service : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ServiceType ServiceType { get; set; }
        public decimal Price { get; set; }

        public ICollection<Reservation> Reservations { get; set; } = null!;
    }
}

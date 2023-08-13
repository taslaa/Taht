namespace Taht.Core
{
    public class ServiceDto : BaseDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ServiceType ServiceType { get; set; }
        public decimal Price { get; set; }
    }
}

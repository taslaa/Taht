namespace Taht.Core
{
    public class ServiceUpsertDto : BaseUpsertDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ServiceType ServiceType { get; set; }
        public decimal Price { get; set; }
    }
}

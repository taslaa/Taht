namespace Taht.Core
{
    public class ServiceUpsertDto : BaseUpsertDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
    }
}

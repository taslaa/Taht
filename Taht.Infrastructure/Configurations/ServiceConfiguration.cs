using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Taht.Core;

namespace Taht.Infrastructure
{
    public class ServiceConfiguration : BaseConfiguration<Service>
    {
        public override void Configure(EntityTypeBuilder<Service> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Name)
                   .IsRequired();

            builder.Property(e => e.Description)
                   .IsRequired();

            builder.Property(e => e.Price)
                   .IsRequired();
        }
    }
}

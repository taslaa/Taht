using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Taht.Core;

namespace Taht.Infrastructure
{
    public class AppointmentConfiguration : BaseConfiguration<Appointment>
    {
        public override void Configure(EntityTypeBuilder<Appointment> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.AppointmentDate)
                   .IsRequired();

            builder.Property(e => e.AppointmentTime)
                   .IsRequired();

            builder.Property(e => e.IsBooked)
                   .IsRequired();
        }
    }
}


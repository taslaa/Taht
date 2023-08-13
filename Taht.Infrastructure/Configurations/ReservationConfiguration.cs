﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Taht.Core;

namespace Taht.Infrastructure
{
    public class ReservationConfiguration : BaseConfiguration<Reservation>
    {
        public override void Configure(EntityTypeBuilder<Reservation> builder)
        {
            base.Configure(builder);

            builder.HasOne(e => e.User)
                   .WithMany(e => e.Reservations)
                   .HasForeignKey(e => e.UserId)
                   .IsRequired();

            builder.HasOne(e => e.Service)
                   .WithMany(e => e.Reservations)
                   .HasForeignKey(e => e.ServiceId)
                   .IsRequired();

            builder.Property(e => e.BookingTime)
                   .IsRequired();

            builder.Property(e => e.GuestCount)
                   .IsRequired();
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Taht.Core;

namespace Taht.Infrastructure
{
    public class ReviewConfiguration : BaseConfiguration<Review>
    {
        public override void Configure(EntityTypeBuilder<Review> builder)
        {
            base.Configure(builder);

            builder.HasOne(e => e.User)
                   .WithMany(e => e.Reviews)
                   .HasForeignKey(e => e.UserId)
                   .IsRequired();

            builder.Property(e => e.ReviewRating)
                   .IsRequired();

            builder.Property(e => e.ReviewComment)
                   .IsRequired(false);

            builder.Property(e => e.IsAnonymous)
                   .IsRequired();
        }
    }
}

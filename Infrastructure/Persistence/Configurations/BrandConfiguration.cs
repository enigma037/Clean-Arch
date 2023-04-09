using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class BrandConfiguration : BaseConfiguration<Brand>
    {
        public override void Configure(EntityTypeBuilder<Brand> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(p => p.Description)
                .HasMaxLength(1000)
                .IsRequired();
        }
    }
}

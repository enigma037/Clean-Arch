using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.Id)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(p => p.IsActive)
                .IsRequired();

            builder.Property(p => p.LastUpdatedAt)
                .IsRequired();

            builder.Property(p => p.LastUpdatedBy)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}

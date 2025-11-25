using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeruGroup.Trade.Domain.Entities;

namespace PeruGroup.Trade.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(o => o.Id);

            builder.Property(x => x.Id)
                .HasPrecision(9, 0)
                .IsRequired()
                .ValueGeneratedNever();

            builder.Property(o => o.Symbol)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(o => o.Side)
                .HasMaxLength(1)
                .IsRequired();

            builder.Property(o => o.TransactTime)
                .IsRequired();

            builder.Property(o => o.Quanty)
                .HasPrecision(9, 0)
                .IsRequired();

            builder.Property(o => o.Type)
                .HasMaxLength(1)
                .IsRequired();

            builder.Property(o => o.Price)
                .HasPrecision(9, 4)
                .IsRequired();

            builder.Property(o => o.Currency)
                .HasMaxLength(3)
                .IsRequired()
                .HasDefaultValue("USD");

            builder.Property(o => o.Text)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(x => x.Created)
                .IsRequired();

            builder.Property(x => x.CreatedBy)
                .HasMaxLength(120)
                .IsRequired();

            builder.Property(o => o.LastModified)
                .IsRequired(false);

            builder.Property(o => o.LastModifiedBy)
                .HasMaxLength(120)
                .IsRequired(false);
        }
    }
}

using FinancialProcessingTaxation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Mappings
{
    public class PaymentMap : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.InvoiceId).IsRequired();
            builder.Property(p => p.Amount).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.PaymentDate).IsRequired();
            builder.Property(p => p.Status).IsRequired();
        }
    }
}

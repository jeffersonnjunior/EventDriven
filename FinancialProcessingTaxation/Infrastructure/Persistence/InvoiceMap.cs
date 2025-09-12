using FinancialProcessingTaxation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialProcessingTaxation.Infrastructure.Persistence
{
    public class InvoiceMap : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.IssueDate).IsRequired();
            builder.Property(i => i.Amount).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(i => i.Status).IsRequired();
            builder.HasMany(i => i.Taxes);
        }
    }
}

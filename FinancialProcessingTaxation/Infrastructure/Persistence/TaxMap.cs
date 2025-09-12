using FinancialProcessingTaxation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialProcessingTaxation.Infrastructure.Persistence
{
    public class TaxMap : IEntityTypeConfiguration<Tax>
    {
        public void Configure(EntityTypeBuilder<Tax> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
            builder.Property(t => t.Rate).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(t => t.Type).IsRequired();
        }
    }
}

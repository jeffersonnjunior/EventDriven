using FinancialProcessingTaxation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialProcessingTaxation.Infrastructure.Mapping
{
    public class TaxRuleMap : IEntityTypeConfiguration<TaxRule>
    {
        public void Configure(EntityTypeBuilder<TaxRule> builder)
        {
            builder.HasKey(tr => tr.Id);
            builder.Property(tr => tr.TaxType).IsRequired();
            builder.Property(tr => tr.MinValue).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(tr => tr.MaxValue).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(tr => tr.Rate).IsRequired().HasColumnType("decimal(18,2)");
        }
    }
}

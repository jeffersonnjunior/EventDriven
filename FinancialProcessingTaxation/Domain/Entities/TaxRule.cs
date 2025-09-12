using System;
using FinancialProcessingTaxation.Domain.Enums;

namespace FinancialProcessingTaxation.Domain.Entities
{
    public class TaxRule
    {
        public Guid Id { get; set; }
        public TaxType TaxType { get; set; }
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
        public decimal Rate { get; set; }
    }
}

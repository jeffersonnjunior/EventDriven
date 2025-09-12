using System;
using FinancialProcessingTaxation.Domain.Enums;

namespace FinancialProcessingTaxation.Domain.Entities
{
    public class Tax
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public TaxType Type { get; set; }
    }
}

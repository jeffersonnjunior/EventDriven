using System.Collections.Generic;

namespace FinancialProcessingTaxationModule.Domain.Entities
{
    public class TaxCalculationResult
    {
        public decimal TotalEconomy { get; set; }
        public List<TaxBenefitCalculation> BenefitCalculations { get; set; }
    }
}
using System;
using System.Collections.Generic;
using FinancialProcessingTaxationModule.Domain.Enums;

namespace FinancialProcessingTaxationModule.Domain.Entities
{
    public class TaxBenefitCalculation
    {
        public Guid BenefitId { get; set; }
        public string BenefitName { get; set; }
        public TaxBenefitType BenefitType { get; set; }
        public decimal EconomyValue { get; set; }
        public List<TaxBenefitCalculation> SubBenefitCalculations { get; set; }
    }
}
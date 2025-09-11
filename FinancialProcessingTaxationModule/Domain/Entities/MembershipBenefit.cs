using System;
using System.Collections.Generic;
using FinancialProcessingTaxationModule.Domain.Enums;

namespace FinancialProcessingTaxationModule.Domain.Entities
{
    public class MembershipBenefit
    {
        public Guid BenefitId { get; set; }
        public string BenefitName { get; set; }
        public TaxBenefitType BenefitType { get; set; }
        public decimal BenefitValue { get; set; }
        public List<MembershipBenefit> SubBenefits { get; set; }
    }
}
using System;
using FinancialProcessingTaxationModule.Domain.Enums;

namespace FinancialProcessingTaxationModule.Domain.Entities
{
    public class TaxCalculationEvent
    {
        public Guid Id { get; set; }
        public DateTime ReceivedAt { get; set; }
        public MembershipPlanEvent MembershipPlanEvent { get; set; }
        public TaxCalculationResult CalculationResult { get; set; }
        public TaxCalculationStatus Status { get; set; }
    }
}
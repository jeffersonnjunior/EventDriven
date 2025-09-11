using System;
using System.Collections.Generic;

namespace FinancialProcessingTaxationModule.Domain.Entities
{
    public class MembershipPlanEvent
    {
        public Guid PlanId { get; set; }
        public string PlanName { get; set; }
        public decimal PlanValue { get; set; }
        public List<MembershipBenefit> Benefits { get; set; }
    }
}
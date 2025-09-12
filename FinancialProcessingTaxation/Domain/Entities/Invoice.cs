using System;
using System.Collections.Generic;
using FinancialProcessingTaxation.Domain.Enums;

namespace FinancialProcessingTaxation.Domain.Entities
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal Amount { get; set; }
        public InvoiceStatus Status { get; set; }
        public List<Tax> Taxes { get; set; }
    }
}

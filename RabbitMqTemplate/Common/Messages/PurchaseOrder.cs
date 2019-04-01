using System;

namespace Common.Messages
{
    [Serializable]
    public class PurchaseOrder
    {
        public decimal Amount { get; }
        public string PoNumber { get; }
        public string CompanyName { get; }
        public int PaymentDayTerms { get; }
    }
}

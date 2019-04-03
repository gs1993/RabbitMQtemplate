using System.Collections.Generic;
using Common.Messages;
using Common.Messages.ValueObjects;

namespace Common.Utils
{
    public static class SampleData
    {
        public static List<Payment> SamplePayments()
        {
            var result = new List<Payment>(6);

            var amount1 = Amount.Create(100, "EUR", 2).Value;
            var cardNr1 = CardNumber.Create("4111 1111 1111 1111").Value;
            result.Add(Payment.Create(amount1, cardNr1, "Payment name 1").Value);

            var amount2 = Amount.Create(1200, "EUR", 2).Value;
            var cardNr2 = CardNumber.Create("4111 1111 1111 1111").Value;
            result.Add(Payment.Create(amount1, cardNr1, "Payment name 2").Value);

            var amount3 = Amount.Create(50.49m, "PLN", 2).Value;
            var cardNr3 = CardNumber.Create("4111 1111 1111 1111").Value;
            result.Add(Payment.Create(amount1, cardNr1, "Payment name 3").Value);

            var amount4 = Amount.Create(10, "EUR", 2).Value;
            var cardNr4 = CardNumber.Create("4111 1111 1111 1111").Value;
            result.Add(Payment.Create(amount1, cardNr1, "Payment name 1").Value);

            var amount5 = Amount.Create(120, "EUR", 2).Value;
            var cardNr5 = CardNumber.Create("4111 1111 1111 1111").Value;
            result.Add(Payment.Create(amount1, cardNr1, "Payment name 2").Value);

            var amount6 = Amount.Create(5.49m, "PLN", 2).Value;
            var cardNr6 = CardNumber.Create("4111 1111 1111 1111").Value;
            result.Add(Payment.Create(amount1, cardNr1, "Payment name 3").Value);

            return result;
        }
    }
}

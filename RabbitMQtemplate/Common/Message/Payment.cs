using System;
using Common.Message.ValueObjects;
using CSharpFunctionalExtensions;

namespace Common.Message
{
    [Serializable]
    public class Payment
    {
        private Payment(Amount amount, CardNumber cardNumber, string name)
        {
            Amount = amount;
            CardNumber = cardNumber;
            Name = name;
        }
        

        public Amount Amount { get; }
        public CardNumber CardNumber { get; }
        public string Name { get; }


        public static Result<Payment> Create(Amount amount, CardNumber cardNumber, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return Result.Fail<Payment>("Name cannot be null");

            return Result.Ok<Payment>(new Payment(amount, cardNumber, name));
        }
    }
}

using System;
using System.Linq;
using CSharpFunctionalExtensions;

namespace Common.Message.ValueObjects
{
    public class Amount
    {
        private const int _currencyLength = 3;


        private Amount(decimal amountValue, string currency, int decimalPlaces)
        {
            AmountValue = amountValue;
            Currency = currency;
            DecimalPlaces = decimalPlaces;
        }


        public decimal AmountValue { get; }
        public string Currency { get; }
        public int DecimalPlaces { get; }


        public static Result<Amount> Create(decimal amountValue, string currency, int decimalPlaces)
        {
            if(amountValue < 0)
                return Result.Fail<Amount>("Amount cannot be less than zero");

            if (string.IsNullOrEmpty(currency) || currency.Length != _currencyLength)
                return Result.Fail<Amount>("Invalid currency length");

            if (!currency.All(Char.IsLetter))
                return Result.Fail<Amount>("Currency should be only letters");

            if (decimalPlaces < 0)
                return Result.Fail<Amount>("Decimal places cannot be less than zero");

            return Result.Ok(new Amount(amountValue, currency, decimalPlaces));
        }
    }
}

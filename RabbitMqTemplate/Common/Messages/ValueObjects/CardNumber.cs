using System;
using System.Text;
using CSharpFunctionalExtensions;

namespace Common.Messages.ValueObjects
{
    public class CardNumber
    {
        private CardNumber(string cardNumber)
        {
            Value = cardNumber;
        }


        public string Value { get; }


        public static Result<CardNumber> Create(string cardNumber)
        {


            return Result.Ok(new CardNumber(cardNumber));
        }

        public static bool IsCardNumberValid(string cardNumber)
        {
            int i, checkSum = 0;

            // Compute checksum of every other digit starting from right-most digit
            for (i = cardNumber.Length - 1; i >= 0; i -= 2)
                checkSum += (cardNumber[i] - '0');

            // Now take digits not included in first checksum, multiple by two,
            // and compute checksum of resulting digits
            for (i = cardNumber.Length - 2; i >= 0; i -= 2)
            {
                int val = ((cardNumber[i] - '0') * 2);
                while (val > 0)
                {
                    checkSum += (val % 10);
                    val /= 10;
                }
            }

            // Number is valid if sum of both checksums MOD 10 equals 0
            return ((checkSum % 10) == 0);
        }

        public static string NormalizeCardNumber(string cardNumber)
        {
            if (cardNumber == null)
                cardNumber = String.Empty;

            StringBuilder sb = new StringBuilder();

            foreach (char c in cardNumber)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);
            }

            return sb.ToString();
        }
    }
}

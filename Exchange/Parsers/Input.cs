using System;
using Exchange.Domain.ValueObjects;

namespace Exchange.Parsers
{
    public class Input
    {
        public Iso Currency1 { get; }
        public Iso Currency2 { get; }
        public decimal Amount { get; }

        public Input(Iso currency1, Iso currency2, decimal amount)
        {
            Currency1 = currency1 ?? throw new ArgumentNullException(nameof(currency1));
            Currency2 = currency2 ?? throw new ArgumentNullException(nameof(currency2));
            Amount = amount;
        }
    }
}

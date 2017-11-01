using System;
using Exchange.Domain.ValueObjects;

namespace Exchange.Domain.Currencies
{
    public abstract class Currency
    {
        protected Currency(string name, Iso iso, decimal exchangeRate, decimal amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Iso = iso ?? throw new ArgumentNullException(nameof(iso.Value));
            ExchangeRate = exchangeRate;
            Amount = amount;
        }

        public string Name { get; }
        public Iso Iso { get; }
        public decimal Amount { get; }
        public decimal ExchangeRate { get; }


        public decimal ExchangeTo(Currency currency, int amountToExchange)
        {
            if (currency == null) throw new ArgumentNullException(nameof(currency));
            return (Amount / currency.Amount) * amountToExchange;
        }
    }
}

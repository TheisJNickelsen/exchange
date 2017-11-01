using System;
using Exchange.Domain.ValueObjects;

namespace Exchange.Domain.Currencies
{
    public abstract class Currency
    {
        protected Currency(string name, Iso iso, decimal exchangeRate, decimal amount = 0m)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Iso = iso ?? throw new ArgumentNullException(nameof(iso.Value));
            ExchangeRate = exchangeRate;
            Amount = amount;
        }

        public string Name { get; }
        public Iso Iso { get; }
        public decimal Amount { get; private set; }
        public decimal ExchangeRate { get; }

        public void ChangeAmount(decimal amount)
        {
            Amount = amount;
        } 

        public void ExchangeTo(Currency currency)
        {
            if (currency == null) throw new ArgumentNullException(nameof(currency));
            currency.ChangeAmount(ExchangeRate / currency.ExchangeRate * Amount);
        }
    }
}

using System;
using Exchange.Domain.ValueObjects;

namespace Exchange.Domain.Currencies
{
    public class Currency
    {
        public Currency(string name, Iso iso, decimal danishExchangeRate)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Iso = iso ?? throw new ArgumentNullException(nameof(iso.Value));
            DanishExchangeRate = danishExchangeRate;
        }

        public string Name { get; }
        public Iso Iso { get; }
        public decimal DanishExchangeRate { get; }
    }
}

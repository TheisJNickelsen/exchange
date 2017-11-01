using Exchange.Domain.Currencies;
using Exchange.Exceptions;

namespace Exchange.Domain
{
    public static class CurrencyFactory
    {
        public static Currency Create(string iso)
        {
            switch (iso)
            {
                case "EUR":
                    return new Euro();
                case "DKK":
                    return new DanishKrone();
                case "USD":
                    return new Dollar();
                case "GBP":
                    return new Pounds();
                case "SEK":
                    return new SwedishKrone();
                case "NOK":
                    return new NorwegianKrone();
                case "CHF":
                    return new Franc();
                case "JPY":
                    return new Yen();
                default:
                    throw new UnsupportedCurrencyException("Unknown currency: " + iso);
            }
        }

        public static Currency Create(string iso, decimal amount)
        {
            switch (iso)
            {
                case "EUR":
                    return new Euro();
                case "DKK":
                    return new DanishKrone();
                case "USD":
                    return new Dollar();
                case "GBP":
                    return new Pounds();
                case "SEK":
                    return new SwedishKrone();
                case "NOK":
                    return new NorwegianKrone();
                case "CHF":
                    return new Franc();
                case "JPY":
                    return new Yen();
                default:
                    throw new UnsupportedCurrencyException("Unknown currency: " + iso);
            }
        }
    }
}

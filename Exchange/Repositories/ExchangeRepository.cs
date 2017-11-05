using Exchange.Domain.Currencies;
using Exchange.Domain.ValueObjects;
using System.Collections.Generic;

namespace Exchange.Repositories
{
    public class ExchangeRepository : IExchangeRepository
    {
        public List<Currency> GetCurrencies()
        {
            return new List<Currency>
            {
                new Currency("Danish krone",new Iso("DKK"), 100.00m),
                new Currency("Euro",new Iso("EUR"), 743.94m),
                new Currency("American dollars",new Iso("USD"), 663.11m),
                new Currency("British pounds",new Iso("GBP"), 852.85m),
                new Currency("Swedish krone",new Iso("SEK"), 76.10m),
                new Currency("Norwegian krone",new Iso("NOK"), 78.40m),
                new Currency("Schweizerfranc",new Iso("CHF"), 683.58m),
                new Currency("Japanese yen",new Iso("JPY"), 5.974m)
            };
        }
    }
}

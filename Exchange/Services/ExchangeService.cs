using Exchange.Domain;
using Exchange.Domain.Currencies;

namespace Exchange.Services
{
    public class ExchangeService
    {
        public Currency Exchange(Currency _currency, string toCurrency)
        {
            var currency = CurrencyFactory.Create(toCurrency);



            (_currency.ExchangeRate / currency.ExchangeRate) * _currency.Amount;
        }
    }
}

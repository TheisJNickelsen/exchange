using Exchange.Domain.ValueObjects;
using Exchange.Repositories;
using System;
using System.Linq;

namespace Exchange.Services
{
    public class ExchangeService : IExchangeService
    {
        private readonly IExchangeRepository _exchangeRepository;

        public ExchangeService(IExchangeRepository exchangeRepository)
        {
            _exchangeRepository = exchangeRepository ?? throw new ArgumentNullException(nameof(exchangeRepository));
        }

        public decimal ExchangeCurrencies(Iso currency1, Iso currency2, decimal amount)
        {
            var currencies = _exchangeRepository.GetCurrencies();

            var curr1 = currencies.FirstOrDefault(c => c.Iso.Equals(currency1));
            var curr2 = currencies.FirstOrDefault(c => c.Iso.Equals(currency2));

            if(curr1 == null) throw new ArgumentException("Currency1 not found: " + currency1.Value);
            if(curr2 == null) throw new ArgumentException("Currency2 not found: " + currency2.Value);

            return curr1.DanishExchangeRate / curr2.DanishExchangeRate * amount;
        }
    }
}

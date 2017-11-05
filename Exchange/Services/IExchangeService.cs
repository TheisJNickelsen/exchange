using Exchange.Domain.ValueObjects;

namespace Exchange.Services
{
    public interface IExchangeService
    {
        decimal ExchangeCurrencies(Iso currency1, Iso currency2, decimal amount);
    }
}

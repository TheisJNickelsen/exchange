using Exchange.Domain.Currencies;
using Exchange.Domain.ValueObjects;
using Exchange.Repositories;
using Exchange.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Exchange.Tests.ServiceTests
{
    public class ExchangeServiceTests : ExchangeTestBase, IDisposable
    {
        public Mock<IExchangeRepository> ExchangeRepository;
        public readonly IExchangeService ExchangeService;

        public ExchangeServiceTests()
        {
            ExchangeRepository = new Mock<IExchangeRepository>();
            ExchangeService = new ExchangeService(ExchangeRepository.Object);
            ExchangeRepository
                .Setup(x => x.GetCurrencies())
                .Returns(new List<Currency>
                {
                    new Currency("Danish krone",new Iso("DKK"), 100.00m),
                    new Currency("Euro",new Iso("EUR"), 743.94m),
                    new Currency("American dollars",new Iso("USD"), 663.11m),
                    new Currency("British pounds",new Iso("GBP"), 852.85m),
                    new Currency("Swedish krone",new Iso("SEK"), 76.10m),
                    new Currency("Norwegian krone",new Iso("NOK"), 78.40m),
                    new Currency("Schweizerfranc",new Iso("CHF"), 683.58m),
                    new Currency("Japanese yen",new Iso("JPY"), 5.974m)
                });
        }

        [Fact]
        public void ShouldBeAbleToExchangeAllSupportedCurrencies()
        {
            foreach (var curr1 in SupportedCurrencies)
            {
                foreach (var curr2 in SupportedCurrencies)
                {
                    ExchangeService.ExchangeCurrencies(new Iso(curr1), new Iso(curr2), 10);
                }
            }
        }

        [Fact]
        public void ShouldFailOnNotSupportedCurrency()
        {
            Assert.Throws<ArgumentException>(() => ExchangeService.ExchangeCurrencies(new Iso(SupportedCurrencies.FirstOrDefault()), new Iso("TST"), 10));
            Assert.Throws<ArgumentException>(() => ExchangeService.ExchangeCurrencies(new Iso("TST"), new Iso(SupportedCurrencies.FirstOrDefault()), 10));
        }

        public void Dispose()
        {
        }
    }
}

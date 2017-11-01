using System;
using Exchange.Domain;
using Exchange.Domain.Currencies;
using Xunit;

namespace Exchange.Tests.DomainTests.CurrencyTests
{
    public class EuroTests
    {
        [Fact]
        public void ShouldExchangeOnExchangeTo()
        {
            var eur = CurrencyFactory.Create("EUR", 1);

            var dkk = CurrencyFactory.Create("DKK");

            eur.ExchangeTo(dkk);

            Assert.NotEqual(0m, dkk.Amount);
        }

        [Fact]
        public void ExchangeToShouldFailOnNullCurrency()
        {
            var eur = CurrencyFactory.Create("EUR", 1);

            Assert.Throws<ArgumentNullException>(() => eur.ExchangeTo(null));
        }
    }
}

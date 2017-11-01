using Exchange.Domain;
using Exchange.Exceptions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Exchange.Tests
{
    public class CurrencyFactoryBase
    {
        protected List<string> SupportedCurrencies = new List<string>
        {
            "EUR",
            "USD",
            "GBP",
            "SEK",
            "NOK",
            "CHF",
            "JPY",
            "DKK"
        };
    }

    public class CurrencyFactoryTests : CurrencyFactoryBase
    {
        [Fact]
        public void ShouldSupportedCurrenciesOnCreate()
        {
            foreach (var curr in SupportedCurrencies)
            {
                var currency = CurrencyFactory.Create(curr);

                Assert.Equal(currency.Iso.Value, curr);
            }
        }

        [Fact]
        public void ShouldFailOnUnsupportedCurrency()
        {
            Assert.Throws<UnsupportedCurrencyException>(() => 
            CurrencyFactory.Create("UnsupportedCurrency"));
        }
    }
}

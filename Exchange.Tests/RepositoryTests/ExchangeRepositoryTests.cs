using Exchange.Repositories;
using System.Linq;
using Xunit;

namespace Exchange.Tests.RepositoryTests
{
    public class ExchangeRepositoryTests : ExchangeTestBase
    {
        public IExchangeRepository ExchangeRepository;
        public ExchangeRepositoryTests()
        {
            ExchangeRepository = new ExchangeRepository();
        }

        [Fact]
        public void ShouldReturnSupportedCurrenciesOnGetCurrencies()
        {
            var currencies = ExchangeRepository.GetCurrencies();

            foreach (var curr in currencies.Select(c => c.Iso.Value))
            {
                Assert.Contains(curr, SupportedCurrencies);
            }
        }
    }
}

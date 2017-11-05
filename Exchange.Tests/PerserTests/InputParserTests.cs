using Exchange.Parsers;
using System;
using Xunit;

namespace Exchange.Tests.PerserTests
{
    public class InputParserTests : IDisposable
    {
        readonly IInputParser _inputParser;

        public InputParserTests()
        {
            _inputParser = new InputParser();
        }

        [Fact]
        public void ShouldBeAbleToParseCorrectInput()
        {
            const int amount = 10;
            const string currency1 = "DKK";
            const string currency2 = "EUR";

            var input = _inputParser.GetInput("Exchange " + currency1 +  "/" + currency2 + " " + amount);

            Assert.Equal(amount, input.Amount);
            Assert.Equal(currency1, input.Currency1.Value);
            Assert.Equal(currency2, input.Currency2.Value);
        }

        [Fact]
        public void ShouldFailOnWrongInputFormat()
        {
            Assert.Throws<Exception>(() => _inputParser.GetInput("Exchange test"));
        }

        [Fact]
        public void ShouldFailOnWrongAmountFormat()
        {
            Assert.Throws<Exception>(() => _inputParser.GetInput("Exchange EUR/DKK test"));
        }

        public void Dispose()
        {
        }
    }
}

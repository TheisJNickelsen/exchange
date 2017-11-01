using Exchange.Domain.ValueObjects;
using System;
using Xunit;

namespace Exchange.Tests.DomainTests.ValueObjectTests
{
    public class IsoTests
    {
        [Fact]
        public void ShouldCreateIsoOnCorrectCharacterLength()
        {
            var iso = new Iso("ASD");
            Assert.NotNull(iso);
        }

        [Fact]
        public void ShouldFailOnIsoDifferentThanThreeCharacters()
        {
            Assert.Throws<ArgumentException>(() => new Iso("ASDF"));
        }
    }
}

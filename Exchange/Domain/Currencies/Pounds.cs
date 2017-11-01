using Exchange.Domain.ValueObjects;

namespace Exchange.Domain.Currencies
{
    public class Pounds : Currency
    {
        public Pounds() 
            : base("British pounds", new Iso("GBP"), 852.85m)
        {
        }
    }
}

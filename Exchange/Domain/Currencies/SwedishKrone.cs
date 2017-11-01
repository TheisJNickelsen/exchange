using Exchange.Domain.ValueObjects;

namespace Exchange.Domain.Currencies
{
    public class SwedishKrone : Currency
    {
        public SwedishKrone() 
            : base("Swedish krone", new Iso("SEK"), 76.10m)
        {
        }
    }
}

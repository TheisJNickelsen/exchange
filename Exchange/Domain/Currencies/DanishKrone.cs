using Exchange.Domain.ValueObjects;

namespace Exchange.Domain.Currencies
{
    public class DanishKrone : Currency
    {
        public DanishKrone() 
            : base("Danish krone", new Iso("DKK"), 100.00m)
        {
        }
    }
}

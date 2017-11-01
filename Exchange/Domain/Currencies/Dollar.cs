using Exchange.Domain.ValueObjects;

namespace Exchange.Domain.Currencies
{
    public class Dollar : Currency
    {
        public Dollar() 
            : base("American dollar", new Iso("USD"), 663.11m)
        {
        }
    }
}

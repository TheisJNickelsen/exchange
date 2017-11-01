using Exchange.Domain.ValueObjects;

namespace Exchange.Domain.Currencies
{
    public class Franc : Currency
    {
        public Franc() 
            : base("Schwetzingen Frank", new Iso("CHF"), 683.58m)
        {
        }
    }
}

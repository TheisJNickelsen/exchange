using Exchange.Domain.ValueObjects;

namespace Exchange.Domain.Currencies
{
    public class Yen : Currency
    {
        public Yen() 
            : base("Japanese yen", new Iso("JPY"), 5.9740m)
        {
        }
        public Yen(decimal amount)
            : base("Japanese yen", new Iso("JPY"), 5.9740m, amount)
        {
        }
    }
}

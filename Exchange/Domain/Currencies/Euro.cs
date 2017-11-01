﻿using Exchange.Domain.ValueObjects;

namespace Exchange.Domain.Currencies
{
    public class Euro : Currency
    {
        public Euro() 
            : base("Euro", new Iso("EUR"), 743.94m)
        {
        }
        public Euro(decimal amount)
            : base("Euro", new Iso("EUR"), 743.94m, amount)
        {
        }
    }
}

﻿using Exchange.Domain.ValueObjects;

namespace Exchange.Domain.Currencies
{
    public class NorwegianKrone : Currency
    {
        public NorwegianKrone() 
            : base("Norwegian krone", new Iso("NOK"), 78.40m)
        {
        }
    }
}
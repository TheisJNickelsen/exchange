using System;

namespace Exchange.Exceptions
{
    public class UnsupportedCurrencyException : Exception
    {
        public UnsupportedCurrencyException()
        {
        }

        public UnsupportedCurrencyException(string message)
            : base(message)
        {
        }

        public UnsupportedCurrencyException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

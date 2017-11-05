using System;

namespace Exchange.Domain.ValueObjects
{
    public class Iso
    {
        public string Value { get; }
        public Iso(string value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
            if (value.Length != 3) throw new ArgumentException("ISO can only be of 3 characters");
        }

        public override bool Equals(object obj)
        {
            var item = obj as Iso;
            return item != null && item.Value == Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}

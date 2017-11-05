using System;
using Exchange.Domain.ValueObjects;

namespace Exchange.Parsers
{
    public class InputParser : IInputParser
    {
        public Input GetInput(string cmdArgs)
        {
            try
            {
                var inArr = cmdArgs.Split(' ');

                decimal amount;
                if (decimal.TryParse(inArr[2], out amount))
                {
                    return new Input(new Iso(inArr[1].Split('/')[0]), new Iso(inArr[1].Split('/')[1]), amount);
                }
                throw new Exception("Amount cannot be parsed. cmdArgs: " + cmdArgs);
            }
            catch (Exception)
            {
                throw new Exception("Input cannot be parsed. cmdArgs: " + cmdArgs);
            }
        }
    }
}

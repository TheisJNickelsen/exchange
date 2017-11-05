namespace Exchange.Parsers
{
    public interface IInputParser
    {
        Input GetInput(string cmdArgs);
    }
}

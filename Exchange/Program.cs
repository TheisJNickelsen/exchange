using Exchange.Parsers;
using Exchange.Repositories;
using Exchange.Services;
using System;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            //DI setup preferred
            IExchangeRepository exchangeRepository = new ExchangeRepository();
            IExchangeService exchangeService = new ExchangeService(exchangeRepository);
            IInputParser inputParser = new InputParser();

            string inputArgs;
            do
            {
                inputArgs = Console.ReadLine();

                if (inputArgs != null && inputArgs.Equals("Exchange"))
                {
                    Console.WriteLine("Usage: Exchange <currency pair> <amount to exchange>");
                }
                else
                {
                    try
                    {
                        var input = inputParser.GetInput(inputArgs);
                        if (input == null) continue;
                        Console.WriteLine(
                            exchangeService.ExchangeCurrencies(
                                input.Currency1,
                                input.Currency2,
                                input.Amount));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Value read = {1}.", e.Message, inputArgs);
                    }
                }
            } while (inputArgs != null && !inputArgs.Equals("+"));
        }
    }
}

using Exchange.Domain;
using System;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                input = Console.ReadLine();
                try
                {
                    if (input != null && input.Equals("Exchange"))
                    {
                        Console.WriteLine("Usage: Exchange <currency pair> <amount to exchange>");
                    }
                    else
                    {
                        if (input != null)
                        {
                            try
                            {
                                var inArr = input.Split(' ');
                                
                                int amount;
                                if (int.TryParse(inArr[2], out amount))
                                {
                                    var currency1 = CurrencyFactory.Create(inArr[1].Split('/')[0], amount);
                                    var currency2 = CurrencyFactory.Create(inArr[1].Split('/')[1]);

                                    currency1.ExchangeTo(currency2);
                                    Console.WriteLine(currency2.Amount);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("{0} Value read = {1}.", e.Message, input);
                            }
                        }
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("{0} Value read = {1}.", e.Message, input);
                }
            } while (input != "+");
        }

    }
}

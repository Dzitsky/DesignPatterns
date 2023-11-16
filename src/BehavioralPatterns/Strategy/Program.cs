using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var strategy = new BaseStrategy();
            WithdrawService service = new WithdrawService(strategy);
            service.ValidateAmount(100);

            Console.ReadKey();
        }
    }
}
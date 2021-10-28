using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Balancer balancer = new Balancer();
            IService adapter = new Adapter(balancer);

            GetBalance(adapter);

            Console.ReadKey();
        }

        static void GetBalance(IService service)
        {
            string accountNumber = "";
            string result = service.Balance(accountNumber);
            Console.WriteLine(result);
        }
    }
}
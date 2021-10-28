using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            Proxy proxy = new Proxy(service);

            GetBalance(proxy);

            Console.ReadKey();
        }

        static void GetBalance(IService service)
        {
            string accountNumber = "";
            //Check accountNumber?
            string result = service.Balance(accountNumber);
            Console.WriteLine(result);        
        }
    }
}
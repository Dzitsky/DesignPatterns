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
            //Check number?
            string  result = service.Balance("");
            Console.WriteLine(result);        
        }
    }
}
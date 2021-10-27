namespace Proxy
{
    class Proxy : IService
    {
        private Service service;

        public Proxy(Service service)
        { 
            this.service = service;
        }

        public string Balance(string accountNumber)
        {
            if (string.IsNullOrEmpty(accountNumber))
            {
                //throw new ArgumentException("Incorrect account number");
                return "Incorrect account number";
            }

            return service.Balance(accountNumber);
        }
    }
}
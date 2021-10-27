namespace Proxy
{
    class Service : IService
    {
        public string Balance(string accountNumber)
        {
            //Check accountNumber?
            return $"Balance for account {accountNumber} : $$$"; 
        }
    }
}
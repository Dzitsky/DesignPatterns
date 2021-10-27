namespace Adapter
{
    class Adapter : IService
    {
        private Balancer balancer;

        public Adapter(Balancer balancer)
        {
            this.balancer = balancer;
        }

        public string Balance(string accountNumber)
        {
            balancer.SetAccountNumber(accountNumber);
            return balancer.GetBalance();
        }
    }
}
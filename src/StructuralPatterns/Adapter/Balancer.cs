namespace Adapter
{
    class Balancer
    {
        private string? _accountNumber;

        public void SetAccountNumber(string accountNumber)
        {
            _accountNumber = accountNumber;
        }

        public string GetBalance()
        {
            if (string.IsNullOrEmpty(_accountNumber))
            {
                return "Account not set";
            }
            return $"Balance for account {_accountNumber} : $$$";
        }
    }
}
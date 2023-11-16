namespace Strategy
{
    public interface IWithdrawStrategy
    {
        decimal GetAmountToDecrease(decimal amount);
        bool ValidateAmount(decimal amount);
    }

    public class WithdrawService
    {
        public WithdrawService(IWithdrawStrategy strategy)
        {
            Strategy = strategy;
        }

        IWithdrawStrategy Strategy { get; set; }

        public decimal GetAmountToDecrease(decimal amount)
        {
            return Strategy.GetAmountToDecrease(amount);
        }

        public bool ValidateAmount(decimal amount)
        {
            return Strategy.ValidateAmount(amount);
        }
    }

    public class BaseStrategy: IWithdrawStrategy{
        public decimal GetAmountToDecrease(decimal amount)
        {
            return amount * (decimal)1.03;
        }

        public bool ValidateAmount(decimal amount)
        {
            if (amount > 500)
            {
                return true;
            }
            return false;
        }
    }

    public class VipStrategy: IWithdrawStrategy{
        public decimal GetAmountToDecrease(decimal amount)
        {
            return amount * (decimal)1.01;
        }

        public bool ValidateAmount(decimal amount)
        {
            if (amount > 5000)
            {
                return true;
            }
            return false;
        }
    }
}
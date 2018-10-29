using System;

namespace Chapter2
{
    public class BankAccount
    {
        private double AccountBalance { get; set; }
        private double TaxRate { get; set; }

        public double GetAccountBalance()
        {
            double balanceAfterTax = GetBalanceAfterTax();
            return balanceAfterTax;
        }

        private double GetBalanceAfterTax()
        {
            return AccountBalance * TaxRate;
        }
    }
}
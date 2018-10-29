using System;

namespace Chapter2
{
    public class BankAccount
    {
        public string owner;

        public BankAccount()
        {
            owner = "Some person";
        }

        public BankAccount(string theOwner)
        {
            owner = theOwner;
        }
    }
}
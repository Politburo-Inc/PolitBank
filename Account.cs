using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitBank
{
    internal class Account
    {
        internal string[] accountTypes = { "Cheque", "Savings" };
        public string Name { get; set; }
        public float InitialDeposit { get; set; }
        public float Funds { get; set; }
        private string _accountType;
        public string AccountType
        {
            get => _accountType;
            set
            {
                foreach (string validAccountType in accountTypes) // broken
                {
                    if (value != validAccountType)
                    {
                        Console.WriteLine("Invalid Account Type!!");
                        Console.WriteLine($"Input: {value}");
                        Console.Write("Valid Options: ");
                        foreach (string itemAccountType in accountTypes)
                        {
                            Console.Write($"{itemAccountType}");
                            Console.Write("");
                        }
                    }
                    else
                    {
                        _accountType = value;
                    }
                }
            }
        }
        public int id = 0;

        internal Account(string name, float initialDeposit, string accountType)
        {
            this.Name = name;
            this.InitialDeposit = initialDeposit;
            this.Funds = initialDeposit;
            this.AccountType = accountType;
            this.id = id + 1;
        }
    }
}

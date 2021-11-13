using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitBank
{
    internal static class Bank
    {
        internal static List<User> users = new List<User>();
        internal static List<Account> accounts = new List<Account>();   

        internal static void createAccount()
        {
            Console.WriteLine("Enter new Account name: ");
            Console.Write("> ");
            string accountName = Console.ReadLine();
            Console.WriteLine("Assining default Id...");
            Console.WriteLine("Enter starting amount...");
            string accountStartingAmount = Console.ReadLine();
            int proccessedAccountStartingAmount = -1;
            proccessedAccountStartingAmount = Validator.validate(accountStartingAmount, proccessedAccountStartingAmount, createAccount);
            Console.WriteLine("Specify account type: ");
            string accountType = Console.ReadLine();
            Console.WriteLine("Creating Account...");
            Account newAccount = new Account(accountName, proccessedAccountStartingAmount, accountType);
        }

        internal static void deleteAccount()
        {
            Console.WriteLine("Enter Account name: ");
            string accountName = Console.ReadLine();
            foreach (Account account in accounts)
            {
                if (account.Name != accountName)
                {
                    Console.WriteLine("Account does not exist!");
                }
                else
                {
                    Console.WriteLine("Account exists!");
                    Console.WriteLine("Deleteing account...");
                    accounts.Remove(account);
                }
            }
        }

        internal static void withdrawMoney()
        {
            Console.WriteLine("Enter Account name: ");
            string accountName = Console.ReadLine();
            foreach (Account account in accounts)
            {
                if (account.Name != accountName)
                {
                    Console.WriteLine("Account does not exist!");
                }
                else
                {
                    float proccessedWithdrawAmount = 0.0f;
                    Console.WriteLine("Account exists!");
                    Console.WriteLine("How much would you like to withdraw? ");
                    Console.Write("> ");
                    string withdrawAmount = Console.ReadLine();
                    proccessedWithdrawAmount = Validator.validateFloat(withdrawAmount, proccessedWithdrawAmount, withdrawMoney);
                    try
                    {
                        account.Funds -= proccessedWithdrawAmount;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("ERROR: Invalid funds to make withdrawal!");
                    }
                }
            }
        }

        internal static void depositMoney()
        {
            Console.WriteLine("Enter Account name: ");
            string accountName = Console.ReadLine();
            foreach (Account account in accounts)
            {
                if (account.Name != accountName)
                {
                    Console.WriteLine("Account does not exist!");
                }
                else
                {
                    float proccessedDepositAmount = 0.0f;
                    Console.WriteLine("Account exists!");
                    Console.WriteLine("How much would you like to deposit? ");
                    Console.Write("> ");
                    string depositAmount = Console.ReadLine();
                    proccessedDepositAmount = Validator.validateFloat(depositAmount, proccessedDepositAmount, depositMoney);
                    try
                    {
                        account.Funds += proccessedDepositAmount;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("ERROR: Deposit failed!");
                    }
                }
            }
        }
    }
}

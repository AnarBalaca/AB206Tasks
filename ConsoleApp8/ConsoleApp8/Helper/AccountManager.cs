using ConsoleApp8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Helper
{
    public static class AccountManager
    {
        static BankAccount[] bankAccounts = new BankAccount[0];

        public static void CreateAccount(BankAccount account)
        {
            if (account == null)
            {
                Console.WriteLine("null ola bilmez");
                return;
            }

            Array.Resize(ref bankAccounts, bankAccounts.Length + 1);
            bankAccounts[^1] = account;
            Console.WriteLine("Created Succesfully");
        }

        public static BankAccount GetAccount(int id)
        {
            BankAccount FoundAccount = null;

            foreach (BankAccount bankAccount in bankAccounts)
            {
                if (bankAccount.Id == id)
                {
                    return FoundAccount = bankAccount;
                }
            }
            return FoundAccount;
        }
        public static void Deposit(int id, double amount)
        {
            BankAccount acc = GetAccount(id);
            if (acc == null)
            {
                Console.WriteLine("tapilmadi(user)");
            }
            else
            {
                if (amount <= 0)
                {
                    Console.WriteLine("a bala get iw tap");
                }
                else
                {
                    acc.Balance += amount;
                    Console.WriteLine("balansiniz artdi :)");
                }
            }
        }


        public static void Withdraw(int id, double amount)
        {
            BankAccount acc = GetAccount(id);
            if (acc == null)
            {
                Console.WriteLine("tapilmadi(IBAD(YANKILI))");
            }
            else
            {
              if(amount >= 0)
                {
                    if (acc.Balance < amount)
                    {
                        Console.WriteLine("KASIB(IBAD QULAG ASMIR)");
                    }
                    else
                    {
                        acc.Balance -= amount;
                        Console.WriteLine("NUW OLSUN :)");
                    }
                }
                else
                {
                    Console.WriteLine("menfi pul olar? gic!!!!(YANKILI)");
                }
            }
        }

        public static void GetBalance(int id)
        {
            BankAccount foundAccount = GetAccount(id);
            Console.WriteLine($"Balance:{foundAccount.Balance}");
        }

    }
}

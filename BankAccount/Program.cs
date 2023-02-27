using BankAccount.Entities;
using BankAccount.Entities.Exceptions;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, balance, limit);

            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine());

            try
            {
                account.Withdraw(withdraw);

                Console.WriteLine(account);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw erro: " + e.Message);
            }

        }
    }
}
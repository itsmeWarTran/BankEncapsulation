using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How much do you have in your bank account?");
            double howMuch = Double.Parse(Console.ReadLine());

          

            var money = new BankAccount(howMuch);

            Console.WriteLine("Do you want to deposit?");
            string wantsDeposit = Console.ReadLine();

            if (wantsDeposit == "yes")
            {
                Console.WriteLine("How much do you want to deposit?");
                double muchDeposit = Double.Parse(Console.ReadLine());
                money.Deposit(muchDeposit);
                var getAmount = money.GetBalance();
                Console.WriteLine("You total amount is $" + getAmount);
            }
            else
            {
                Console.WriteLine("OK! Have a great day");
            }
           

            

        }
    }
}

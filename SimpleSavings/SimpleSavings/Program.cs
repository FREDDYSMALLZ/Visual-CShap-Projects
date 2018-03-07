using System;

namespace SimpleSavings
{
    class Program
    {
        static void Main(string[] args)
        {
            Simplesavings1 ss1Acc = new Simplesavings1();
            Console.WriteLine("The inititial balance is {0:C}", ss1Acc.GetBalance());
            ss1Acc.Deposit(400.00);
            ss1Acc.Withdraw(50.00);

            Console.WriteLine("The Current balance is {0:C}", ss1Acc.GetBalance());


            Console.ReadLine();
        }


    }

    internal class Simplesavings1
    {
        internal void Deposit(double v)
        {
            throw new NotImplementedException();
        }

        internal int GetBalance()
        {
            throw new NotImplementedException();
        }

        internal void Withdraw(double v)
        {
            throw new NotImplementedException();
        }
    }
}

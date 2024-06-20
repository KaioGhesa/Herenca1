using System.Diagnostics;

using Herenca1.Entites;

namespace Herenca1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(1001, "Alex", 0.0);
            BussinessAccount bacc = new BussinessAccount(1002, "Maria",0.0, 500.0);


            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BussinessAccount(1003, "bob", 0.0, 500.0);
            Account acc3 = new SavingsAccount(1004, "Aninha", 0.0, 400.0);

            //DownCasting

            BussinessAccount acc4 = (BussinessAccount)acc2;
            acc4.Loan(100.00);

            //BussinessAccount acc5 = (BussinessAccount)acc3;
            if(acc3 is BussinessAccount) 
            {
                BussinessAccount acc5 = (BussinessAccount)acc3;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}

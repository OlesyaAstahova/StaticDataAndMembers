using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        //Данные уровня экземпляра.
        public double currBalance;
        public static double currInterestRate = 0.04; //Это статические данные
        //Cтатический элемент данных.
        public SavingsAccount(double balance)
        {
        currBalance = balance;
        }
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor\n");
            currInterestRate = 0.04;
        }
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
           {
             return currInterestRate;
           }
        
    }
}

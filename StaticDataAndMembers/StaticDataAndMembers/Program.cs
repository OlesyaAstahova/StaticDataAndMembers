using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** fun with Static Data ****\n");
            //Создать счет
            SavingsAccount s1 = new SavingsAccount(50);
            //Вывести текущую процентную ставку
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

          
            // Попытаться изменить процентную ставку через свойство
            SavingsAccount.SetInterestRate(0.08);

            //Создать второй счет
            SavingsAccount s2 = new SavingsAccount(100);

            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            //SavingsAccount s3 = new SavingsAccount(10000.75);
            
            Console.ReadLine();

        }
    }
}

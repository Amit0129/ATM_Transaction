using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMtranjaction
{
    public class ATM
    {
        public int PrintBlance(int mainBlance)
        {
            Console.WriteLine("Your current blance is Rs : " + mainBlance);
            return mainBlance;
        }
        public int Withdraw(int mainBlance)
        {
            Console.WriteLine("Enter the withdraw amount");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            if (withdraw % 100 != 0)
            {
                Console.WriteLine("Please enter the withdral amount multiple of 100");
            }
            else if (withdraw > mainBlance)
            {
                Console.WriteLine("Insuffient Blance\n");
            }
            else
            {
                mainBlance -= withdraw;
                Console.WriteLine("Current Blance is Rs : " + mainBlance);
            }
            return mainBlance;
        }
        public int Deposite(int mainBlance)
        {
            Console.WriteLine("Enter The Deposite Amount");
            int deposit = Convert.ToInt32(Console.ReadLine());
            if (deposit % 100 != 0)
            {
                Console.WriteLine("Please enter the deposit amount multiple of 100");
            }
            else
            {
                mainBlance += deposit;
                Console.WriteLine("Deposite Sucessfully");
                Console.WriteLine("Current Blance is Rs : " + mainBlance);
            }
            return mainBlance;
        }
    }
}

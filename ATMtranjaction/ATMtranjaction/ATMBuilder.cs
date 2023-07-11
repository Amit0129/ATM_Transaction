using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMtranjaction
{
    public class ATMBuilder
    {
        public void ATMOp()
        {
            int mainBlance = 2000;
            int deposit;
            int withdraw;
            bool check = true;
            while (check)
            {
                Console.WriteLine("1. Current Blance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposite");
                Console.WriteLine("4. Cancel");
                Console.WriteLine("Enter your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your current blance is Rs : "+mainBlance);
                        break;
                    case 2:
                        Console.WriteLine("Enter the withdraw amount");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw %100 != 0)
                        {
                            Console.WriteLine("Please enter the withdral amount multiple of 100");
                        }
                        else if (withdraw > mainBlance)
                        {
                            Console.WriteLine("Insuffient Blance");
                        }
                        else
                        {
                            mainBlance -= withdraw;
                            Console.WriteLine("Current Blance is Rs : "+mainBlance);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter The Deposite Amount");
                        deposit = Convert.ToInt32(Console.ReadLine());
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
                        break;
                    case 4:
                        Console.WriteLine("THANK YOU...");
                        check = false;
                        break;
                }
            }
        }
        
    }
}

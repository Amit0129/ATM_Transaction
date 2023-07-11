using System.Text.RegularExpressions;

namespace ATMtranjaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ATMBuilder aTMBuilder = new ATMBuilder();
            //aTMBuilder.ATMOp();
            string pinPtr = "^[1-9]{1}[0-9]{3,5}$";
            Console.WriteLine("Enter Your Pin");
            string pin = Console.ReadLine();
            if (Regex.IsMatch(pin,pinPtr))
            {
                int mainBlance = 2000;
                bool check = true;
                while (check)
                {
                    ATM aTM = new ATM();
                    Console.WriteLine("1. Current Blance");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Deposite");
                    Console.WriteLine("4. Cancel");
                    Console.WriteLine("Enter your Choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            mainBlance = aTM.PrintBlance(mainBlance);
                            break;
                        case 2:
                            mainBlance = aTM.Withdraw(mainBlance);
                            break;
                        case 3:
                            mainBlance = aTM.Deposite(mainBlance);
                            break;
                        case 4:
                            Console.WriteLine("THANK YOU...");
                            check = false;
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
           
        }
    }
}
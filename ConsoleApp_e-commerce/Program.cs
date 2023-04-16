using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
     class Program
    {
        static void Main(string[] args)
        {
            //RunAccount();

            Color.ColorWrite();

            Console.ReadLine();
        }

        static void RunAccount()
        {
            User user = new User();

            int transaction = -1;

            while (true)
            {
                Console.WriteLine("1- Seller");
                Console.WriteLine("2- Customer");
                transaction = Convert.ToInt32(Console.ReadLine());

                if (transaction == 1)
                {
                    User.userType = UserType.Seller;
                    break;
                }

                else if (transaction == 2)  
                {
                    User.userType = UserType.Customer;
                    break;
                }
                else
                {
                    Console.WriteLine("You made the wrong choice");  //Yanlış tercih yaptınız
                }
            }

            user.UserTransactions();
        }
    }
}

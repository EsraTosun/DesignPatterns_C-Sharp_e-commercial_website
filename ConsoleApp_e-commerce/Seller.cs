using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class Seller : User   //Satıcı
    {
        public static void SellerAccount()    //Satıcı Hesabı
        {
            foreach (User sellerList in SellerList)
            {
                Console.WriteLine(sellerList.ToString());
            }
            
        }
    }
}

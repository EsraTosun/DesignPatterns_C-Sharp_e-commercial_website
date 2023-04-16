using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    enum SellerAccountType   //Satıcı hesap tipleri
    {
        AccountInformation = 1,
        //ViewYourProducts = 2,
        AddProduct = 2,
        DeleteProduct = 3,
        Logout = 4,
    }
    class Seller : User,ISeller   //Satıcı
    {
        static Seller seller = new Seller();
        static User user = new User();
        public static void SellerAccount()    //Satıcı Hesabı
        {
            int transaction = -1;
            while (true)
            {
                Console.WriteLine("1- Account information"); //Hesap bilgileri
            //    Console.WriteLine("2- View your products");  //Ürünlerini görüntüle
                Console.WriteLine("2- Add product");   //Ürün ekle
                Console.WriteLine("3- Delete product");   //Ürün Sil
                Console.WriteLine("4- Logout");  //Çıkış yap
                transaction = Convert.ToInt32(Console.ReadLine());

                if(transaction == (int)SellerAccountType.AccountInformation)
                {
                    user.AccountInformation();
                }
                /*else if(transaction == 2)
                {
                    
                }  */
                else if(transaction == (int)SellerAccountType.AddProduct)
                {
                    seller.AddProduct();
                }
                else if(transaction == (int)SellerAccountType.DeleteProduct)
                {
                    seller.DeleteProduct();
                }
            }
            /*foreach (User sellerList in SellerList)
            {
                Console.WriteLine(sellerList.ToString());
            }  */           
        }

        public void AddProduct()
        {
            Products.ProductAdd(Products.productsTypeFinding());            
        }

        public void DeleteProduct()
        {
            
        }

        public void ViewYourProducts()
        {
            throw new NotImplementedException();
        }
    }
}

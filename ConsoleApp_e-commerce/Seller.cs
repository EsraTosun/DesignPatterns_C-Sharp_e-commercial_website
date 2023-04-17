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
        ViewYourProducts = 2,
        AddProduct = 2,
        DeleteProduct = 3,
        Logout = 4,
    }
    class Seller : User,ISeller   //Satıcı
    {
        static Seller seller = new Seller();
        static Products products = new Products();
        static User user = new User();
        SellerProductsTransactions productsTransactions = new SellerProductsTransactions();
        public static void SellerAccount()    //Satıcı Hesabı
        {
            int transaction = -1;
            while (true)
            {
                Console.WriteLine("1- Account information"); //Hesap bilgileri
                Console.WriteLine("2- View your products");  //Ürünlerini görüntüle
                Console.WriteLine("3- Add product");   //Ürün ekle
                Console.WriteLine("4- Delete product");   //Ürün Sil
                Console.WriteLine("5- Logout");  //Çıkış yap
                transaction = Convert.ToInt32(Console.ReadLine());

                if(transaction == (int)SellerAccountType.AccountInformation)
                {
                    user.AccountInformation();
                }
                else if(transaction == (int)SellerAccountType.ViewYourProducts)
                {
                    
                }  
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
            productsTransactions.ProductAdd(SellerProductsTransactions.productsTypeFinding());            
        }

        public void DeleteProduct()
        {
            productsTransactions.ProductDelete(SellerProductsTransactions.productsTypeFinding());
        }

        public void ViewYourProducts()
        {
            
        }
    }
}

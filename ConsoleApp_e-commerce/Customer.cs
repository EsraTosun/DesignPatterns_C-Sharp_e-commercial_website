using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    enum CustomerAccountType
    {
        AccountInformation = 1,
        Products = 2,
        MyBasket = 3,
        Favorites = 4,
        Logout = 5,
    }
    class Customer:User, ICustomer  //Müşteri
    {
        static Products products = new Products();
        static User user = new User();

        public static List<Products> favoritesList = new List<Products>();
        public static List<Products> myBasketList = new List<Products>();  

        int transactionID = -1;
        int transaction = -1;

        public void Favorites()
        {
            throw new NotImplementedException();
        }

        public void MyBasket()
        {
            throw new NotImplementedException();
        }

        public void ProductsList()    //Ürünler
        {
            Products.SellerProductsList();
            Console.WriteLine("Enter the ID of the product you have selected");
            //Seçtiğiniz ürünün ID'si giriniz
            transactionID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1 - MyBasket Add");
            Console.WriteLine("2 - Favorites Add");
            Console.WriteLine("Enter a number other than 1 and 2 to avoid action");
            //İşlem yapılmaması için 1 ve 2 dışında bir sayı giriniz
            transaction = Convert.ToInt32(Console.ReadLine());

            if(transaction == 1)
            { 
            
            }
            else if(transaction == 2)
            {

            }
        }

        public void MyBasketListAdd()
        {

        }

        public void FavoriteListAdd()
        {

        }
    }
}

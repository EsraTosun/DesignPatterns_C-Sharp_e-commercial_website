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
        Payment = 5,
        Logout = 6,
    }
    class Customer:User, ICustomer  //Müşteri
    {
        static Products products = new Products();
        static User user = new User();

        public static List<Products> favoritesList = new List<Products>();
        public static List<Products> myBasketList = new List<Products>();  

        int transactionID = -1;
        int transaction = -1;

        public static int desiredProductsIndex = -1;
        public static int desiredProductsAmound = -1;
        public static ProductsType desiredProductsType;

        public void ProductsList()    //Ürünler
        {
            products.ProductsList();
            Console.WriteLine("Enter the ID of the product you have selected");
            //Seçtiğiniz ürünün ID'si giriniz
            transactionID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1 - MyBasket Add");
            Console.WriteLine("2 - Favorites Add");
            Console.WriteLine("Enter a number other than 1 and 2 to avoid action");
            //İşlem yapılmaması için 1 ve 2 dışında bir sayı giriniz
            transaction = Convert.ToInt32(Console.ReadLine());

            Products.FindingDesiredProduct(transactionID);
            products.amount = desiredProductsAmound;
            products.ID = desiredProductsIndex;
            products.productType = desiredProductsType;

            if (transaction == 1)
            {
                favoritesList.Add(products);
            }
            else if(transaction == 2)
            {
                myBasketList.Add(products);
            }
            else
            {
                Console.WriteLine("The product has not been added");
                //Ürün eklenmedi
            }
        }

        public void MyBasket()
        {
            for(int i=0; i<myBasketList.Count;  i++)
            {
                if (myBasketList[i].productType == ProductsType.tshirt)
                {
                    Console.WriteLine(Seller.tshirtsList[myBasketList[i].ID].ToString());
                }
                else if(myBasketList[i].productType == ProductsType.dress)
                {
                    Console.WriteLine(Seller.dressList[myBasketList[i].ID].ToString());
                }
                else if(myBasketList[i].productType == ProductsType.pants)
                {
                    Console.WriteLine(Seller.tshirtsList[myBasketList[i].ID].ToString());
                }
            }
        }

        public void Favorites()
        {
            for (int i = 0; i < favoritesList.Count; i++)
            {
                if (favoritesList[i].productType == ProductsType.tshirt)
                {
                    Console.WriteLine(Seller.tshirtsList[favoritesList[i].ID].ToString());
                }
                else if (favoritesList[i].productType == ProductsType.dress)
                {
                    Console.WriteLine(Seller.dressList[favoritesList[i].ID].ToString());
                }
                else if (favoritesList[i].productType == ProductsType.pants)
                {
                    Console.WriteLine(Seller.tshirtsList[favoritesList[i].ID].ToString());
                }
            }
        }

        public void PaymentTransaction()
        {
            Payment.PaymentListFinding();
        }
    }
}

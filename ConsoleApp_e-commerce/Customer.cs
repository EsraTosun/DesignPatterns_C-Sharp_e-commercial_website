using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class Customer:User, ICustomer  //Müşteri
    {
        static Products products = new Products();
        static User user = new User();

        int transaction = -1;

        public static void CustomerAccount()    //Müşteri Hesabı
        {

        }

        public void Favorites()
        {
            throw new NotImplementedException();
        }

        public void MyAccount()
        {
            throw new NotImplementedException();
        }

        public void MyBasket()
        {
            throw new NotImplementedException();
        }

        public void ProductsList()    //Ürünler
        {
            

        }
    }
}

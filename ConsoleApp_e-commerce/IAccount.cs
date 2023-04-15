using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
     interface IAccount  //Hesap Ara Yüzü
     {
        void UserType(String UserType);
        //Kullanıcı tipine göre işlemlere devam et
        //Girilen kullanıcı(satıcı veya müşteri) sayfasına yönlendir.
        //UserType enum tipi oluştur müşteri ve satıcı tipi diye 
        //String yerine UserType olsun
    }

    interface IUser  //Hesap Ara Yüzü olacak
     {
        bool LogIn();  //Oturum açma
        void LogOut();  //Oturum kapatma

        string Name { get; set; }
        string PhoneNumber { get; set; }
        string EmailAddress { get; set; }
        string Password { get; set; }
        string Adress { get; set; }

    }

    interface ISeller //Satıcı
    {
        string StoreName { get; set; }

        void AddProduct();   //Ürün Ekle
        void DeleteProduct();  //Ürün Sil
    }

    interface ICustomer  //Müşteri
    {
        void Homepage();   //Ana sayfa
        void MyBasket();  //Sepetim
        void Favorites();  //Favoriler
        void Products();  //Ürünler
        void MyAccount();  //Hesabım
    }
}

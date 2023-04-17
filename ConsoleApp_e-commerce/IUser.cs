﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    interface IUser  //Hesap Ara Yüzü olacak
    {
        void UserTypeLeading();  //Kullanıcı tipi öğrenme
        //Kullanıcı tipine göre işlemlere devam et
        //Girilen kullanıcı(satıcı veya müşteri) olması giriş şeklini değiştirmediği için
        //ortak alan olan kullanıcı kısımda gerçekleştir.
        //UserType enum tipi oluştur müşteri ve satıcı tipi diye 
        //String yerine UserType olsun

        void LogIn();  //Giriş Yap
        void UserTransactions();    //tüm Kullanıcıların başta yapacağı işlemler
        void LogOut();  //Çıkıi Yap
        void NewCreatingAnAccount();   //Hesap Oluşturma
        void AccountInformation();    //Hesap Bilgileri
    }

    interface ISeller //Satıcı
    {
        void AddProduct();   //Ürün Ekle
        void DeleteProduct();  //Ürün Sil
        void ViewYourProducts();   //Ürünlerini görüntüle
    }

    interface ICustomer  //Müşteri
    {
        void MyBasket();  //Sepetim
        void Favorites();  //Favoriler
        void ProductsList();  //Ürünler
        void MyAccount();  //Hesabım
    }
}

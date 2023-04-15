using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
     interface IProduct  //Ürün Ara Yüzü ya da ürün classı olacak
     {
        string Brand { get; set; }   //Marka
        string Body { get; set; }    //Beden

        void ProductType(String productType);  //Ürün tipi
     }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    public enum ProductsType
    {
        allProduct,  //Tüm ürünler
        pants,       //pantolon
        tshirt,      //tişört
        dress        //elbise
    }

    class Products  //Ürünler
    {
        Dress dress = new Dress();
        Pants pants = new Pants();
        Tshirt tshirt = new Tshirt();

        void ProductType(ProductsType productType)  //Ürün tipi
        {
            if(productType == ProductsType.allProduct) { }
            else if(productType == ProductsType.pants) { }
            else if( productType == ProductsType.tshirt) { }
            else if (productType == ProductsType.dress) { }
        }
    }
}

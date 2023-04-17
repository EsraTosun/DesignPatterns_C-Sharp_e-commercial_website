using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class Tshirt : Products    //Tişört
    {
        public TshirtPatterns tshirtPatterns;          //tişört kalıbı
        public TshirtBodys tshirtBodys;                //tişört bedeni
        public TshirtFabricType tshirtFabricType;     //tişört kumaşı

        /*public Tshirt()
            :base()
        {

        }
        public Tshirt(int UserId, int ID, Brand brand, float amount, ColorType color, ProductsType productsType)
            :base(UserId, ID, brand, amount, color, productsType)
        {

        }  */
        public static void SortTheTshirt()
        {
            for (int i = 0; i < SellerProductsTransactions.tshirtsList.Count; i++)
            {
                Console.WriteLine(SellerProductsTransactions.tshirtsList[i].ToString());
            }
        }

        public static void SellerSortTheTshirt(int index)
        {
            for(int i = 0; i < SellerProductsTransactions.tshirtsList.Count; i++)
            {
                if(SellerProductsTransactions.tshirtsList.ElementAt(i).UserID == index)
                {
                    Console.WriteLine(SellerProductsTransactions.tshirtsList.ElementAt(i));
                }
            }
        }
    }
}

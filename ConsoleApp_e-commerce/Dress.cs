using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class Dress : Products //Elbise
    {
        public DressLengthPatterns dressLengthPatterns;   //Elbise boyu
        public PantsAndDressBodys pantsAndDressBodys;      //Elbise bedeni
        public DressFabricType dressFabricType;          //Elbise kumaşı

        /*public Dress()
            : base()
        {

        }

        public Dress(int UserId, int ID, Brand brand, float amount, ColorType color, ProductsType productsType)
            : base(UserId, ID, brand, amount, color, productsType)
        {

        }  */

        public static void SortTheDress()
        {
            for (int i = 0; i < SellerProductsTransactions.dressList.Count; i++)
            {
                Console.WriteLine(SellerProductsTransactions.dressList[i].ToString());
            }
        }

        public static void SellerSortTheDress(int index)
        {
            for (int i = 0; i < SellerProductsTransactions.dressList.Count; i++)
            {
                if (SellerProductsTransactions.dressList.ElementAt(i).UserID == index)
                {
                    Console.WriteLine(SellerProductsTransactions.dressList.ElementAt(i));
                }
            }
        }
    }
}

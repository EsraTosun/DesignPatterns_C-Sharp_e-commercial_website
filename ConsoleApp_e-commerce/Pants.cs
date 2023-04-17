﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class Pants : Products   //Pantolon
    {
        public PantTrotterPatterns pantTrotterPatterns;    //Pantolon paça kalıbı
        public PantsAndDressBodys pantsAndDressBodys;      //Pantolon bedeni
        public PantsFabricType pantsFabricType;            //Pantolon kumaşı

        /*public Pants()
            : base()
        {

        }

        public Pants(int UserId, int ID, Brand brand, float amount, ColorType color, ProductsType productsType)
            : base(UserId, ID, brand, amount, color, productsType)
        {

        }  */

        public static void SellerSortThePants(int index)
        {
            for (int i = 0; i < SellerProductsTransactions.pantsList.Count; i++)
            {
                if (SellerProductsTransactions.pantsList.ElementAt(i).UserID == index)
                {
                    Console.WriteLine(SellerProductsTransactions.pantsList.ElementAt(i));
                }
            }
        }

        public static void SortThePants()
        {
            for(int i = 0;i < SellerProductsTransactions.pantsList.Count;i++)
            {
                Console.WriteLine(SellerProductsTransactions.pantsList[i].ToString());
            }
        }
    }
}

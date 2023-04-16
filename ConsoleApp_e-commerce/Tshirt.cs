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

        public static void SortTheTshirt()
        {
            for (int i = 0; i < Products.tshirtsList.Count; i++)
            {
                Console.WriteLine(tshirtsList[i].ToString());
            }
        }
    }
}

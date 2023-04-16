using System;
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

        public static void SortThePants()
        {
            for(int i = 0;i < Products.pantsList.Count;i++)
            {
                Console.WriteLine(pantsList[i].ToString());
            }
        }
    }
}

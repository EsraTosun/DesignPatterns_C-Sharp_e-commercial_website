using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class ProductsTransactions
    {
        Products productsObject = new Products();
        int transaction = -1;

        public static List<Products> productList = new List<Products>();
        public static List<Dress> dressList = new List<Dress>();
        public static List<Tshirt> tshirtsList = new List<Tshirt>();
        public static List<Pants> pantsList = new List<Pants>();

        Dress dress = new Dress();
        Pants pants = new Pants();
        Tshirt tshirt = new Tshirt();

        public void ProductAdd(ProductsType IncomingproductType)  //Ürün tipi
        {
            if (IncomingproductType == ProductsType.allProduct) { }
            else if (IncomingproductType == ProductsType.pants) { }
            else if (IncomingproductType == ProductsType.tshirt) { }
            else if (IncomingproductType == ProductsType.dress) { }
        }

        void PantsProductAdd()
        {
            pants.productType = ProductsType.pants;
            pants.ID = pantsList.Count + 100;
            Console.WriteLine("Enter the price");  //Fiyatını giriniz
            pants.amount = Convert.ToInt32(Console.ReadLine());
            pants.color = Color.ColorFinfing();
            pants.pantsAndDressBodys = BodyChart.PantsAndDressBodysFinding();
            pants.pantTrotterPatterns = Patterns.PantTrotterPatternsFinding();
            pants.pantsFabricType = Fabrics.PantsFabricTypeFinding();
            pantsList.Add(pants);
        }
        void TshirtProductAdd()
        {
            tshirt.productType = ProductsType.tshirt;
            tshirt.ID = pantsList.Count + 200;
            Console.WriteLine("Enter the price");  //Fiyatını giriniz
            tshirt.amount = Convert.ToInt32(Console.ReadLine());
            tshirt.color = Color.ColorFinfing();
            tshirt.tshirtBodys = BodyChart.TshirtBodysFinding();
            tshirt.tshirtPatterns = Patterns.TshirtPatternsFinding();
            tshirt.tshirtFabricType = TshirtFabricType.Cotton;
            tshirtsList.Add(tshirt);
        }
        void DressProductAdd()
        {
            dress.productType = ProductsType.pants;
            dress.ID = pantsList.Count + 300;
            Console.WriteLine("Enter the price");  //Fiyatını giriniz
            dress.amount = Convert.ToInt32(Console.ReadLine());
            dress.color = Color.ColorFinfing();
            dress.pantsAndDressBodys = BodyChart.PantsAndDressBodysFinding();
            dress.dressLengthPatterns = Patterns.DressLengthPatternsFinding();
            dress.dressFabricType = Fabrics.DressFabricTypeFinding();
            dressList.Add(dress);
        }

        public void ProductDelete(ProductsType IncomingproductType)  //Ürün tipi
        {
            if (IncomingproductType == ProductsType.pants)
            {
                PantsProductDelete();
            }
            else if (IncomingproductType == ProductsType.tshirt)
            {
                TshirtProductDelete();
            }
            else if (IncomingproductType == ProductsType.dress)
            {
                DressProductDelete();
            }
        }

        void PantsProductDelete()
        {
            Pants.SortThePants();
            transaction = Convert.ToInt32(Console.ReadLine());

            pantsList.RemoveAt(transaction - 100);
        }
        void TshirtProductDelete()
        {
            Tshirt.SortTheTshirt();
            transaction = Convert.ToInt32(Console.ReadLine());

            tshirtsList.RemoveAt(transaction - 200);
        }
        void DressProductDelete()
        {
            Dress.SortTheDress();
            transaction = Convert.ToInt32(Console.ReadLine());

            dressList.RemoveAt(transaction - 300);
        }


        public static ProductsType productsTypeFinding()
        {
            int transaction = -1;
            while (true)
            {
                Console.WriteLine("1- " + ProductsType.pants);
                Console.WriteLine("2- " + ProductsType.tshirt);
                Console.WriteLine("3- " + ProductsType.dress);
                transaction = Convert.ToInt32(Console.ReadLine());

                if (transaction == (int)ProductsType.pants)
                {
                    return ProductsType.pants;
                }
                else if (transaction == (int)ProductsType.tshirt)
                {
                    return ProductsType.tshirt;
                }
                else if (transaction == 3)
                {
                    return ProductsType.dress;
                }
                else
                {
                    Console.WriteLine("You made the wrong choice");  //Yanlış tercih yaptınız
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    //Body Chart => Beden tablosu
    public enum PantsAndDressBodys  //Pantolon ve elbise bedenleri
    {
        standard = 0,
        thirtsix = 1,
        thirtyeight = 2,
        forty = 3,
        fortytwo = 4,
    }

    public enum TshirtBodys   //tişört bedenleri
    {
        standard,
        xsmall,
        small,
        medium,
        large,
    }

    public class BodyChart
    {
        public static List<String> PantsAndDressBodyslist = Enum.GetNames(typeof(PantsAndDressBodys)).ToList();
        public static List<String> TshirtBodyslist = Enum.GetNames(typeof(TshirtBodys)).ToList();

        public static void PantsAndDressBodysWrite()
        {
            for (int i = 0; i < PantsAndDressBodyslist.Count; i++)
            {
                Console.WriteLine(i + "- " + PantsAndDressBodyslist[i]);
            }
        }
        public static PantsAndDressBodys PantsAndDressBodysFinding()
        {
            int index;
            PantsAndDressBodysWrite();
            Console.WriteLine("Enter the PantsAndDressBodys");
            index = Convert.ToInt32(Console.ReadLine());

            if (index == (int)PantsAndDressBodys.standard)
            {
                return PantsAndDressBodys.standard;
            }
            else if (index == (int)PantsAndDressBodys.thirtsix)
            {
                return PantsAndDressBodys.thirtsix;
            }
            else if (index == (int)PantsAndDressBodys.thirtyeight)
            {
                return PantsAndDressBodys.thirtyeight;
            }
            else if (index == (int)PantsAndDressBodys.forty)
            {
                return PantsAndDressBodys.forty;
            }
            else
            {
                return PantsAndDressBodys.fortytwo;
            }
        }
        public static void TshirtBodysWrite()
        {
            for (int i = 0; i < TshirtBodyslist.Count; i++)
            {
                Console.WriteLine(i + "- " + TshirtBodyslist[i]);
            }
        }
        public static TshirtBodys TshirtBodysFinding()
        {
            int index;
            TshirtBodysWrite();
            Console.WriteLine("Enter the TshirtBodys");
            index = Convert.ToInt32(Console.ReadLine());

            if (index == (int)TshirtBodys.standard)
            {
                return TshirtBodys.standard;
            }
            else if (index == (int)TshirtBodys.xsmall)
            {
                return TshirtBodys.xsmall;
            }
            else if (index == (int)TshirtBodys.small)
            {
                return TshirtBodys.small;
            }
            else if (index == (int)TshirtBodys.medium)
            {
                return TshirtBodys.medium;
            }
            else
            {
                return TshirtBodys.large;
            }
        }
    }
}

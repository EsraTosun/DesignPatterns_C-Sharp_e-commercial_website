using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
        public enum TshirtPatterns  //tişört kalıpları
        {
            standard,
            oversize
        }

        public enum PantTrotterPatterns   //Pantolon paça kalıpları
        {
            tightTrotters,        //dar paça
            normalTrotters,       //normal paça
            wideTrotters,         //Geniş paça
            cuttingCarrots        //Havuş kesim 
        }

        public enum DressLengthPatterns  //elbise boy kalıpları
        {
            shortLenght,   //kısa boy
            kneeLength,    //diz boyu
            longLength,    //uzun boy
        }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PramotionEngineConsole
{
    class ActivePramotions : Products
    {
        public int ThreeAGroup { get; set; } = 3;
        public int TwoBGroup { get; set; } = 2;
        public int CPlusDGroup { get; set; } = 2;
    }


    //Pramotion A
    public class ThreeAPramotion : ISingleProductQuantityPramotion
    {
        public double QuantityPramotion(int quantity)
        {
            return 0;
        }
    }

    //Pramotion B
    public class TwoBPramotion :  ISingleProductQuantityPramotion
    {
        public double QuantityPramotion(int quantity)
        {
            return 0;
        }
    }

    //Pramotion C + D
    public class CPlusDPramotion : IMultipleProductClubbPramotion
    {
        public double ClubbPramotion(int product_C, int product_D)
        {
            return 0;
        }
    }





}

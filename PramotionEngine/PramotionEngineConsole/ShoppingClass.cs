using System;
using System.Collections.Generic;
using System.Text;

namespace PramotionEngineConsole
{
    public class ShoppingClass
    {
        public double ShoppingCart(int A_Quantity = 0, int B_Quantity = 0, int C_Quantity = 0, int D_Quantity = 0)
        {
            double ATotal = new ThreeAPramotion().QuantityPramotion(A_Quantity);
            double BTotal = new TwoBPramotion().QuantityPramotion(B_Quantity);
            double CDTotal = new CPlusDPramotion().ClubbPramotion(C_Quantity, D_Quantity);
            return Math.Round(ATotal + BTotal + CDTotal);            
        }
    }
}

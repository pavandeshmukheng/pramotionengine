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
            double BTotal = 0;
            double CDTotal = 0;
            return Math.Round(ATotal + BTotal + CDTotal);            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PramotionEngineConsole
{
    public class ShoppingClass : Products
    {
        public double ShoppingCart(int A_Quantity = 0, int B_Quantity = 0, int C_Quantity = 0, int D_Quantity = 0)
        {
            double ATotal = new ThreeAPramotion().QuantityPramotion(A_Quantity);
            double BTotal = new TwoBPramotion().QuantityPramotion(B_Quantity);
            double CDTotal = new CPlusDPramotion().ClubbPramotion(C_Quantity, D_Quantity);
            return Math.Round(ATotal + BTotal + CDTotal);
        }

        public double ShoppingCartWithRecommendedPramotion(int A_Quantity = 0, int B_Quantity = 0, int C_Quantity = 0, int D_Quantity = 0)
        {

            #region Old school logic :(
            int A_ActualValue = A_Quantity * SKU_ID_List["A"];
            int B_ActualValue = B_Quantity * SKU_ID_List["B"];
            int C_ActualValue = C_Quantity * SKU_ID_List["C"];
            int D_ActualValue = D_Quantity * SKU_ID_List["D"];
            int CD_ActualValue = C_ActualValue + D_ActualValue;

            double A_DiscountedValue = new ThreeAPramotion().QuantityPramotion(A_Quantity);
            double B_DiscountedValue = new TwoBPramotion().QuantityPramotion(B_Quantity);
            double CD_DiscountedValue = new CPlusDPramotion().ClubbPramotion(C_Quantity, D_Quantity);

            double A_Difference = A_ActualValue - A_DiscountedValue;
            double B_Difference = B_ActualValue - B_DiscountedValue;
            double CD_Difference = CD_ActualValue - CD_DiscountedValue;

            if (A_Difference > B_Difference)
            {
                if (A_Difference > CD_Difference) return Math.Round(A_DiscountedValue + B_ActualValue + CD_ActualValue);
                else return Math.Round(A_ActualValue + B_ActualValue + CD_DiscountedValue);
            }
            else if (B_Difference > CD_Difference) return Math.Round(A_ActualValue + B_DiscountedValue + CD_ActualValue);
            else return Math.Round(A_ActualValue + B_ActualValue + CD_DiscountedValue);      
            #endregion
        }
    }
}

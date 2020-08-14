using System;
using System.Collections.Generic;
using System.Text;

namespace PramotionEngineConsole
{
    public class DiscountCalcultor
    {
        public double Calculate(int productValue, int productGroup, double discountPercent, int quotient, int reminder)
        {
            double finalSum = 0;

            for (int i = 1; i <= quotient; i++)//loop the max possible group
                finalSum = finalSum + (productGroup * productValue) - ((discountPercent / 100) * (productGroup * productValue));

            for (int i = 1; i <= reminder; i++)//loop for the remaning ons if any
                finalSum = finalSum + productValue;

            return finalSum;
        }
    }
}

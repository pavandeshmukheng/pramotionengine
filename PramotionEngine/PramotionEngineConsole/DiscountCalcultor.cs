using System;
using System.Collections.Generic;
using System.Text;

namespace PramotionEngineConsole
{
    //method overloading for Calculate function    
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

        public double Calculate(int product1Value, int product2Value, int extraAdd, double discountPercent, int quotient, int reminder)
        {
            int productValue = product1Value + product2Value;

            double finalSum = 0;

            for (int i = 1; i <= quotient; i++)//loop the max possible group considering group of products as one
                finalSum = finalSum + (1 * productValue) - ((discountPercent / 100) * (1 * productValue));

            for (int i = 1; i <= reminder; i++)//loop for the remaning ons if any
                finalSum = finalSum + productValue;

            finalSum = finalSum + extraAdd;

            return finalSum;
        }
    }
}

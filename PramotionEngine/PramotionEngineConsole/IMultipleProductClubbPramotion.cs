using System;
using System.Collections.Generic;
using System.Text;

namespace PramotionEngineConsole
{
    interface IMultipleProductClubbPramotion
    {
        //Method to return discounted price of multiple products (SKU IDs)
        double ClubbPramotion(int product_C, int product_D);

        //Same can be overload for more than tow products
        //double ClubbPramotion(int product_A, int product_A_Quantity, int product_B, int product_B_Quantity);
    }
}

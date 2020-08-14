using System;
using System.Collections.Generic;
using System.Text;

namespace PramotionEngineConsole
{
    interface ISingleProductQuantityPramotion
    {
        //Method to return discounted price of single product (SKU ID)
        double QuantityPramotion(int quantity);
    }
}

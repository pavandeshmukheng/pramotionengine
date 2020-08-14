using System;
using System.Collections.Generic;
using System.Text;

namespace PramotionEngineConsole
{
    //Achived Interface Segeration Princile by introducing multiple interfaces according to type of work
    interface ISingleProductQuantityPramotion
    {
        //Method to return discounted price of single product (SKU ID)
        double QuantityPramotion(int quantity);
    }
}

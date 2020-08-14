using System;
using System.Collections.Generic;
using System.Text;

namespace PramotionEngineConsole
{
    public class ActivePramotions : Products
    {
        public int ThreeAGroup { get; set; } = 3;
        public int TwoBGroup { get; set; } = 2;
        public int CPlusDGroup { get; set; } = 2;
    }


    //Pramotion A
    public class ThreeAPramotion : ActivePramotions, ISingleProductQuantityPramotion
    {
        //3 of A's for 130 where actual price become 150 so there is 13.3% drop for 3
        private readonly int ProductQuantity = 3;
        private readonly double CurrentDiscount = 13.3;
        public double QuantityPramotion(int quantity)
        {
            Tuple<int, int> Quotient_Reminder = GetQuotientAndReminder(quantity, ProductQuantity);
            return new DiscountCalcultor().Calculate(SKU_ID_List["A"], ProductQuantity, CurrentDiscount, Quotient_Reminder.Item1, Quotient_Reminder.Item2);
        }
    }

    //Pramotion B
    public class TwoBPramotion : ActivePramotions, ISingleProductQuantityPramotion
    {
        //2 of B's for 45 where actual price become 60 so there is 25% drop for 2
        private readonly int ProductQuantity = 2;
        private readonly double CurrentDiscount = 25;
        public double QuantityPramotion(int quantity)
        {
            Tuple<int, int> Quotient_Reminder = GetQuotientAndReminder(quantity, ProductQuantity);
            return new DiscountCalcultor().Calculate(SKU_ID_List["B"], ProductQuantity, CurrentDiscount, Quotient_Reminder.Item1, Quotient_Reminder.Item2);
        }
    }

    //Pramotion C + D
    public class CPlusDPramotion : ActivePramotions, IMultipleProductClubbPramotion
    {
        public double ClubbPramotion(int product_C, int product_D)
        {
            return 0;
        }
    }
}

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
        //C and D for 30 where actual price become 35 so there is 14.28% drop if someone buy C and D in together
        private readonly int ProductGroup = 2;
        private readonly double CurrentDiscount = 14.28;
        public double ClubbPramotion(int product_C_Quantity, int product_D_Quantity)
        {
            Tuple<int, int> Quotient_Reminder = GetQuotientAndReminder(product_C_Quantity + product_D_Quantity, ProductGroup);

            int reminderOnTheBasisOfLargerQuantity = 0;
            if (product_C_Quantity > product_D_Quantity) reminderOnTheBasisOfLargerQuantity = SKU_ID_List["C"];
            if (product_C_Quantity < product_D_Quantity) reminderOnTheBasisOfLargerQuantity = SKU_ID_List["D"];

            return new DiscountCalcultor().Calculate(SKU_ID_List["C"], SKU_ID_List["D"], reminderOnTheBasisOfLargerQuantity, CurrentDiscount, Quotient_Reminder.Item1, 0);
        }
    }
}

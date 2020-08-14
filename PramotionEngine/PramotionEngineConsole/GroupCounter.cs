using System;
using System.Collections.Generic;
using System.Text;

namespace PramotionEngineConsole
{
    public abstract class GroupCounter
    {
        public Tuple<int, int> GetQuotientAndReminder(int Quantity_Dividend, int Group_Divisor)
        {
            int quotient = Math.DivRem(Quantity_Dividend, Group_Divisor, out int reminder);
            return new Tuple<int, int>(quotient, reminder);
        }
    }
}

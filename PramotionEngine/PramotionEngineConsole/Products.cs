using System;
using System.Collections.Generic;
using System.Text;

namespace PramotionEngineConsole
{
    //Products with fixed price SKU IDs
    public class Products
    {
        public Dictionary<string, int> SKU_ID_List { get; set; }
        public Products()
        {
            SKU_ID_List = new Dictionary<string, int>
            {
                { "A", 50 },
                { "B", 30 },
                { "C", 20 },
                { "D", 15 }
            };
        }
    }
}

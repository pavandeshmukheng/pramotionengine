using Microsoft.VisualStudio.TestTools.UnitTesting;
using PramotionEngineConsole;


namespace PramotionEngineUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ScenarioA()
        {
            //Mention quantity of SKU ID's(Products) in order A,B,C,D
            ShoppingClass obj = new ShoppingClass();
            double result = obj.ShoppingCart(1, 1, 1, 0);
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void ScenarioB()
        {
            //Mention quantity of SKU ID's(Products) in order A,B,C,D
            ShoppingClass obj = new ShoppingClass();
            double result = obj.ShoppingCart(5, 5, 1, 0);
            Assert.AreEqual(370, result);
        }

        [TestMethod]
        public void ScenarioC()
        {
            //Mention quantity of SKU ID's(Products) in order A,B,C,D
            ShoppingClass obj = new ShoppingClass();
            double result = obj.ShoppingCart(3, 5, 1, 1);
            Assert.AreEqual(280, result);
        }

        //If one pramotion applied other pramotions will not be applied
        //The pramotion which is system recommendation is best value saving for customer
        [TestMethod]
        public void ScenarioToGetBestMatchOfferOnTheBasisOfSelectedProductAndQuantity()
        {
            //Mention quantity of SKU ID's(Products) in order A,B,C,D
            ShoppingClass obj = new ShoppingClass();
            double result = obj.ShoppingCart(30, 35, 10, 10);
            Assert.AreEqual(1000, result);
        }
    }
}

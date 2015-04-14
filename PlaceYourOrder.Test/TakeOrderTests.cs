using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlaceYourOrder.Test
{
    [TestClass]
    public class TakeOrderTests
    {
        [TestMethod]
        public void Take_order_morning123_ReturnEggsToastCoffee()
        {
            const string input = "morning, 1, 2, 3";
            const string resultExpected = "eggs, toast, coffee";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }


        [TestMethod]
        public void Take_order_morning213_ReturnEggsToastCoffee()
        {
            const string input = "morning, 2, 1, 3";
            const string resultExpected = "eggs, toast, coffee";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void Take_order_morning1234_ReturnEggsToastCoffeeError()
        {
            const string input = "morning, 1, 2, 3, 4";
            const string resultExpected = "eggs, toast, coffee, error";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void Take_order_morning12333_ReturnEggsToastCoffeeX3()
        {
            const string input = "morning, 1, 2, 3, 3, 3";
            const string resultExpected = "eggs, toast, coffee(x3)";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void Take_order_night1234_ReturnSteakPotatoWineCake()
        {
            const string input = "night, 1, 2, 3, 4";
            const string resultExpected = "steak, potato, wine, cake";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void Take_order_night1224_ReturnSteakPotatoX2Cake()
        {
            const string input = "night, 1, 2, 2, 4";
            const string resultExpected = "steak, potato(x2), cake";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void Take_order_night1235_ReturnSteakPotatoWineError()
        {
            const string input = "night, 1, 2, 3, 5";
            const string resultExpected = "steak, potato, wine, error";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void Take_order_night11235_ReturnSteakError()
        {
            const string input = "night, 1, 1, 2, 3, 5";
            const string resultExpected = "steak, error";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }
    }
}

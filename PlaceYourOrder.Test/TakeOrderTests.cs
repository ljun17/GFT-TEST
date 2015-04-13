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
        public void Take_order_morning_1_2_3()
        {
            const string input = "morning, 1, 2, 3";
            const string resultExpected = "eggs, toast, coffee";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }


        [TestMethod]
        public void Take_order_morning_2_1_3()
        {
            const string input = "morning, 2, 1, 3";
            const string resultExpected = "eggs, toast, coffee";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void Take_order_morning_1_2_3_4()
        {
            const string input = "morning, 1, 2, 3, 4";
            const string resultExpected = "eggs, toast, coffee, error";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void Take_order_morning_1_2_3_3_3()
        {
            const string input = "morning, 1, 2, 3, 3, 3";
            const string resultExpected = "eggs, toast, coffee(x3)";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void Take_order_night_1_2_3_4()
        {
            const string input = "night, 1, 2, 3, 4";
            const string resultExpected = "steak, potato, wine, cake";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void Take_order_night_1_2_2_4()
        {
            const string input = "night, 1, 2, 2, 4";
            const string resultExpected = "steak, potato(x2), cake";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void Take_order_night_1_2_3_5()
        {
            const string input = "night, 1, 2, 3, 5";
            const string resultExpected = "steak, potato, wine, error";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void Take_order_night_1_1_2_3_5()
        {
            const string input = "night, 1, 1, 2, 3, 5";
            const string resultExpected = "steak, error";

            string result = OrderingService.TakeOrder(input);
            Assert.AreEqual(resultExpected, result);
        }
    }
}

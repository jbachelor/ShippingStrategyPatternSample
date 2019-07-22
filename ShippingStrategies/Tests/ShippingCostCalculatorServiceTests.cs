using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippingStrategies.Shipping;

namespace ShippingStrategies.Tests
{
    [TestClass]
    public class ShippingCostCalculatorServiceTests
    {
        [TestMethod]
        [DataRow(ShippingOptions.UPS, 4.25)]
        [DataRow(ShippingOptions.USPS, 3.05)]
        [DataRow(ShippingOptions.FedEx, 5.10)]
        public void TestUPSShippingIs425(ShippingOptions shippingMethod, double expectedCost)
        {
            var shippingCalculator = new ShippingCostCalculatorService();
            var order = TestHelpers.CreateOrder(shippingMethod);
            var cost = shippingCalculator.CalculateShippingCost(order);
            Assert.AreEqual((decimal)expectedCost, cost);
        }
    }
}

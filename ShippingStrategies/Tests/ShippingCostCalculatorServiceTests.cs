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
            IShippingCostStrategy shippingCostStrategy;
            switch (shippingMethod)
            {
                case ShippingOptions.FedEx:
                    shippingCostStrategy = new ShippingCostStrategyFedEx();
                    break;
                case ShippingOptions.UPS:
                    shippingCostStrategy = new ShippingCostStrategyUPS();
                    break;
                case ShippingOptions.USPS:
                    shippingCostStrategy = new ShippingCostStrategyUSPS();
                    break;
                default:
                    throw new ArgumentException($"Unknown shipping method: {shippingMethod}");
            }

            var shippingCalculator = new ShippingCostCalculatorService(shippingCostStrategy);
            var order = TestHelpers.CreateOrder(shippingMethod);
            var cost = shippingCalculator.CalculateShippingCost(order);
            Assert.AreEqual((decimal)expectedCost, cost);
        }
    }
}

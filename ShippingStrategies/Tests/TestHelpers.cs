using System;
using ShippingStrategies.Shipping;

namespace ShippingStrategies.Tests
{
    public static class TestHelpers
    {
        public static Order CreateOrder(ShippingOptions shippingMethod)
        {
            return new Order
            {
                ShippingMethod = shippingMethod,
                Destination = CreateAddress_Destination(),
                Origin = CreateAddress_Origin()
            };
        }

        public static Address CreateAddress_Origin()
        {
            return new Address
            {
                ContactName = "Roxy Bachelor",
                AddressLine1 = "3179 Ferncreek Ln",
                City = "Escondido",
                State = "CA",
                ZipCode = "92027"
            };
        }

        public static Address CreateAddress_Destination()
        {
            return new Address
            {
                ContactName = "Cali Bachelor",
                AddressLine1 = "008 Ocean Ave",
                City = "Encinitas",
                State = "CA",
                ZipCode = "92011"
            };
        }
    }
}

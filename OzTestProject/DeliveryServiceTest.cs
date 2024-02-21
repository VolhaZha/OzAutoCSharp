using OzProject;

namespace OzTestProject
{
    [TestClass]
    public class DeliveryServiceTest
    {
        [TestMethod]
        public void DeliveryService_FastestProviderTest()
        {
            DeliveryService deliveryService = new DeliveryService();
            deliveryService.AddDeliveryProvider(new DeliveryMoto());
            deliveryService.AddDeliveryProvider(new DeliveryFoot());

            Order order1 = new Order("Lena", 1234567890123, 500, "123 Main St, City");
            Order order2 = new Order("Mark", 9876543210987, 1000, "456 Park Ave, Town");
            deliveryService.AddOrder(order1);
            deliveryService.AddOrder(order2);

            deliveryService.ProcessOrders();

            IDelivery fastestProvider = deliveryService.FindFastestDeliveryProvider(order1);
            Assert.IsInstanceOfType(fastestProvider, typeof(DeliveryMoto));
        }
        [TestMethod]
        public void DeliverOrder_Should_Print_Delivery_Message()
        {
            Order order = new Order("Olga", 1234567890123, 500, "123 Main St, City");
            DeliveryAuto deliveryAuto = new DeliveryAuto();

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            deliveryAuto.DeliverOrder(order);

            string consoleOutput = sw.ToString().Trim();

            Assert.IsTrue(consoleOutput.Contains("Order by auto delivery registered successfully!"), "Delivery message should indicate successful registration.");
        }
    }
}

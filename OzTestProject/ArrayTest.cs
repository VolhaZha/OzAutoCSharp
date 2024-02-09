using OzProject;

namespace OzTestProject
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void OrderGeneralTest()
        {
            Order order1 = new Order("Whyskey", 4334445551112, 10, "Minsk");
            Order order2 = new Order("Food", 3334447772212, 20, "Wro");
            Order order3 = new Order("Sport", 3754448882212, 300, "Ber");
            Order order4 = new VIPOrder("Martini", 3754448882212, 150, "Ber", "alko");
            Order order5 = new DiscountOrder("Sprite", 3754448882212, 121, "Ber", 21);
            Order order6 = new OrdinaryOrder("Fanta", 3334445551112, 33, "Minsk");

            Order[] orderGeneral = { order1, order2, order3, order4, order5, order6 };

            Assert.AreEqual(6, orderGeneral.Length);
        }
        [TestMethod]
        public void OrderPropertiesNameTest()
        {
            string name = "Test Product";
            long phone = 1234567890123;
            float price = 500.50f;
            string address = "Test Address";

            var order = new Order(name, phone, price, address);

            Assert.AreEqual(name, order.Name);
        }
        [TestMethod]
        public void OrderPropertiesPhoneTest()
        {
            string name = "Test Product";
            long phone = 1234567890123;
            float price = 500.50f;
            string address = "Test Address";

            var order = new Order(name, phone, price, address);

            Assert.AreEqual(phone, order.Phone);
        }
        [TestMethod]
        public void OrderPropertiesPriceTest()
        {
            string name = "Test Product";
            long phone = 1234567890123;
            float price = 500.50f;
            string address = "Test Address";

            var order = new Order(name, phone, price, address);

            Assert.AreEqual(price, order.Price);
        }
        [TestMethod]
        public void OrderPropertiesAddressTest()
        {
            string name = "Test Product";
            long phone = 1234567890123;
            float price = 500.50f;
            string address = "Test Address";

            var order = new Order(name, phone, price, address);

            Assert.AreEqual(address, order.Address);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void OrderPhoneValidationTest()
        {
            new Order("Test", 123456789412563, 100, "Test Address");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void OrderPriceValidationTest()
        {
            new Order("Test", 1234567894125, 10066, "Test Address");
        }
    }
}

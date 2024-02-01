using OzProject;

namespace OzTestProject
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void RemoveAtIndexTest()
        {
            var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
            people.RemoveAt(0);
            Assert.AreEqual(7, people.Count);
        }
        [TestMethod]
        public void ListAddToHeadTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(new ListNode<int>(3));
            list.AddToHead(new ListNode<int>(7));
            list.AddToHead(new ListNode<int>(8));
            Assert.AreEqual(list.Head.data, 8);
        }
        [TestMethod]
        public void ListRemoveParticularValueTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(new ListNode<int>(1));
            list.AddToHead(new ListNode<int>(3));
            list.AddToHead(new ListNode<int>(7));
            list.AddToHead(new ListNode<int>(8));
            list.Remove(9);
            list.Remove(1);
            Assert.AreEqual(3, list.GetCount());
        }
        [TestMethod]
        public void ListGetElementAtTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(new ListNode<int>(1));
            list.AddToHead(new ListNode<int>(3));
            var elementByIndex = list.GetElementAt(0);
            Assert.AreEqual(3, elementByIndex); 
        }
        [TestMethod]
        public void ListCountTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(new ListNode<int>(1));
            list.AddToHead(new ListNode<int>(3));
            int count = list.GetCount();
            Assert.AreEqual(2, count);
        }
       [TestMethod]
        public void NumberFoundTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(new ListNode<int>(1));
            list.AddToHead(new ListNode<int>(3));
            int index = list.Contains(3);
            Assert.IsTrue(index != -1, "Number should be found in the list");
        }
        [TestMethod]
        public void NumberNotFoundTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(new ListNode<int>(1));
            list.AddToHead(new ListNode<int>(3));
            int index = list.Contains(5);
            Assert.IsTrue(index == -1, "Number should not be found in the list");
        }
        [TestMethod]
        public void ListOfOrderItemsTest()
        {
            MyList<Order> listOrder = new MyList<Order>();
            Order order1 = new Order("Whyskey", 4334445551112, 10, "Minsk");
            Order order2 = new Order("Food", 3334447772212, 20, "Wro");
            Order order3 = new Order("Sport", 3754448882212, 300, "Ber");
            Order order4 = new VIPOrder("Martini", 3754448882212, 150, "Ber", "alko");
            listOrder.AddToHead(new ListNode<Order>(order1));
            listOrder.AddToHead(new ListNode<Order>(order2));
            listOrder.AddToHead(new ListNode<Order>(order3));
            listOrder.AddToHead(new ListNode<Order>(order4));
            Assert.AreEqual(order4, listOrder.Head.data);
            Assert.AreEqual(order3, listOrder.Head.nextNode.data);
            Assert.AreEqual(order2, listOrder.Head.nextNode.nextNode.data);
            Assert.AreEqual(order1, listOrder.Head.nextNode.nextNode.nextNode.data);
            Assert.IsNull(listOrder.Head.nextNode.nextNode.nextNode.nextNode);
        }
        [TestMethod]
        public void GenericListTest()
        {
            Order order1 = new Order("Whyskey", 4334445551112, 10, "Minsk");
            Order order2 = new Order("Food", 3334447772212, 20, "Wro");
            Order order3 = new Order("Sport", 3754448882212, 300, "Ber");
            Order order4 = new VIPOrder("Martini", 3754448882212, 150, "Ber", "alko");
            Order order5 = new DiscountOrder("Sprite", 3754448882212, 121, "Ber", 21);
            Order order6 = new OrdinaryOrder("Fanta", 3334445551112, 33, "Minsk");
            List<Order> orders = new List<Order>() { order1, order2, order3, order4, order5, order6};
            Assert.AreEqual(6, orders.Count);
        }
        [TestMethod]
        public void DefaultSortTest()
        {
            Order order1 = new Order("Whyskey", 4334445551112, 10, "Minsk");
            Order order2 = new Order("Food", 1334447772212, 20, "Wro");
            Order order3 = new Order("Sport", 3754448882212, 300, "Ber");
            Order order4 = new VIPOrder("Martini", 3754448882212, 150, "Ber", "alko");
            Order order5 = new DiscountOrder("Sprite", 3754448882212, 121, "Ber", 21);
            Order order6 = new OrdinaryOrder("Fanta", 3334445551112, 33, "Minsk");
            List<Order> orders = new List<Order>() { order1, order2, order3, order4, order5, order6 };
            orders.Sort();
            Assert.AreEqual(order2, orders[0]);
        }
        [TestMethod]
        public void SortByClassesTest()
        {
            Order order1 = new Order("Whyskey", 4334445551112, 10, "Minsk");
            Order order2 = new Order("Food", 1334447772212, 20, "Wro");
            Order order3 = new Order("Sport", 3754448882212, 300, "Ber");
            Order order4 = new VIPOrder("Martini", 3754448882212, 150, "Arg", "alko");
            Order order5 = new DiscountOrder("Sprite", 3754448882212, 121, "Ber", 21);
            Order order6 = new OrdinaryOrder("Fanta", 3334445551112, 33, "Minsk");
            List<Order> orders = new List<Order>() { order1, order2, order3, order4, order5, order6 };
            orders.Sort(new NameComparer());
            Assert.AreEqual(order6, orders[0]);
            orders.Sort(new PriceComparer());
            Assert.AreEqual(order1, orders[0]);
            orders.Sort(new AddressComparer());
            Assert.AreEqual(order4, orders[0]);
        }
        [TestMethod]
        public void LINQSortByNameTest()
        {
            Order order1 = new Order("Whyskey", 4334445551112, 10, "Minsk");
            Order order2 = new Order("Food", 1334447772212, 20, "Wro");
            Order order3 = new Order("Sport", 3754448882212, 300, "Ber");
            Order order4 = new VIPOrder("Martini", 3754448882212, 150, "Arg", "alko");
            Order order5 = new DiscountOrder("Sprite", 3754448882212, 121, "Ber", 21);
            Order order6 = new OrdinaryOrder("Fanta", 3334445551112, 33, "Minsk");
            List<Order> orders = new List<Order>() { order1, order2, order3, order4, order5, order6 };
            var nameSortedOrders = orders.OrderBy(order => order.Name);
            Assert.AreEqual(order6, nameSortedOrders.First());
        }
    [TestMethod]
        public void LINQSortByPriceTest()
        {
            Order order1 = new Order("Whyskey", 4334445551112, 10, "Minsk");
            Order order2 = new Order("Food", 1334447772212, 20, "Wro");
            Order order3 = new Order("Sport", 3754448882212, 300, "Ber");
            Order order4 = new VIPOrder("Martini", 3754448882212, 150, "Arg", "alko");
            Order order5 = new DiscountOrder("Sprite", 3754448882212, 121, "Ber", 21);
            Order order6 = new OrdinaryOrder("Fanta", 3334445551112, 33, "Minsk");
            List<Order> orders = new List<Order>() { order1, order2, order3, order4, order5, order6 };
            var priceSortedOrders = orders.OrderBy(order => order.Price);
            Assert.AreEqual(order1, priceSortedOrders.First());
        }
        [TestMethod]
        public void LINQSortByAddressTest()
        {
            Order order1 = new Order("Whyskey", 4334445551112, 10, "Minsk");
            Order order2 = new Order("Food", 1334447772212, 20, "Wro");
            Order order3 = new Order("Sport", 3754448882212, 300, "Ber");
            Order order4 = new VIPOrder("Martini", 3754448882212, 150, "Arg", "alko");
            Order order5 = new DiscountOrder("Sprite", 3754448882212, 121, "Ber", 21);
            Order order6 = new OrdinaryOrder("Fanta", 3334445551112, 33, "Minsk");
            List<Order> orders = new List<Order>() { order1, order2, order3, order4, order5, order6 };
            var addressSortedOrders = orders.OrderBy(order => order.Address, StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(order4, addressSortedOrders.First());
        }
        [TestMethod]
        public void LINQWhereSelectOrderByTest()
        {
            Order order1 = new Order("Whyskey", 4334445551112, 10, "Minsk");
            Order order2 = new Order("Food", 1334447772212, 20, "Wro");
            Order order3 = new Order("Sport", 3754448882212, 300, "Ber");
            Order order4 = new VIPOrder("Martini", 3754448882212, 150, "Arg", "alko");
            Order order5 = new DiscountOrder("Sprite", 3754448882212, 121, "Ber", 21);
            Order order6 = new OrdinaryOrder("Fanta", 3334445551112, 33, "Minsk");
            List<Order> orders = new List<Order>() { order1, order2, order3, order4, order5, order6 };
            var LinqSortedOrders = orders
                            .Where(order => order.Price <= 100)
                            .OrderBy(order => order.Name, StringComparer.OrdinalIgnoreCase)
                            .Select(order => order.Name); 
            Assert.AreEqual(order6.Name, LinqSortedOrders.First());
            Assert.AreEqual(3, LinqSortedOrders.Count());
        }
        [TestMethod]
        public void LINQTheMostFrequentlyUsedTest()
        {
            Order order1 = new Order("Whyskey", 4334445551112, 10, "Minsk");
            Order order2 = new Order("Food", 1334447772212, 20, "Wro");
            Order order3 = new Order("Sport", 3754448882212, 300, "Ber");
            Order order4 = new VIPOrder("Martini", 3754448882212, 150, "Arg", "alko");
            Order order5 = new DiscountOrder("Sprite", 3754448882212, 121, "Ber", 21);
            Order order6 = new OrdinaryOrder("Fanta", 3334445551112, 33, "Minsk");
            Order order7 = new OrdinaryOrder("Food", 3334445551112, 33, "Minsk");
            List<Order> orders = new List<Order>() { order1, order2, order3, order4, order5, order6, order7 };
            var mostFrequentProductName = orders
                            .GroupBy(order => order.Name, StringComparer.OrdinalIgnoreCase)
                            .OrderByDescending(group => group.Count())
                            .Select(group => group.Key)
                            .FirstOrDefault();
            Assert.AreEqual("Food", mostFrequentProductName);
        }
    }
}

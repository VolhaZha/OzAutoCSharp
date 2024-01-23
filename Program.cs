using OzTest1;

//List Remove 1
var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
people.RemoveAt(0);
Console.WriteLine($"Listpeople: {people.Count}");

//List Add To head
MyList<int> list = new MyList<int>();
list.AddToHead(new ListNode<int>(1));
list.AddToHead(new ListNode<int>(3));
list.AddToHead(new ListNode<int>(7));
list.AddToHead(new ListNode<int>(8));

//List Remove 2
list.Remove(9);
list.Remove(0);
Console.WriteLine($"List: {list.GetCount()}");

//List Get Element At
var elementByIndex = list.GetElementAt(1);

//List Count
int count = list.GetCount();
Console.WriteLine($"Count: {count}");

//List Contains
int index = list.Contains(3);
if (index != -1)
{
    Console.WriteLine($"Number found at index {index}");
}
else
{
    Console.WriteLine("Number not found in the list");
}

//Orders Arrays
Order order1 = new Order("Whyskey", 4334445551112, 10, "Minsk");
Order order2 = new Order("Food", 3334447772212, 20, "Wro");
Order order3 = new Order("Sport", 3754448882212, 300, "Ber");
Order order4 = new VIPOrder("Martini", 3754448882212, 150, "Ber", "alko");
Order order5 = new DiscountOrder("Sprite", 3754448882212, 121, "Ber", 21);
Order order6 = new OrdinaryOrder("Fanta", 3334445551112, 33, "Minsk");
Order order7 = new OrdinaryOrder("Food", 3334445551112, 33, "Minsk");


Order[] orderGeneral = { order1, order2, order3, order4, order5, order6 };

foreach (Order order in orderGeneral)
{
    Console.WriteLine($"Order: {order}");
}

static Order CreateOrder(string name, long phone, float price, string address)
{
    try
    {
        return new Order(name, phone, price, address);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception occurred: {ex.Message} - for {name}");
        return null;
    }
}

//List Of Order Items
MyList<Order> listOrder = new MyList<Order>();
listOrder.AddToHead(new ListNode<Order>(order1));
listOrder.AddToHead(new ListNode<Order>(order2));
listOrder.AddToHead(new ListNode<Order>(order3));
listOrder.AddToHead(new ListNode<Order>(order4));
Console.WriteLine("\nList Of Order Items:");
ListNode<Order>? currentOrderNode = listOrder.Head;
while (currentOrderNode != null)
{
    Console.WriteLine($"Order: {currentOrderNode.data}");
    currentOrderNode = currentOrderNode.nextNode;
}

//List Of Order Items via iEnumerable
Console.WriteLine("\nList Of Order Items iEnumerable:");
foreach (var order in listOrder)
{
    Console.WriteLine($"Order: {order}");
}

//Generic List
List<Order> orders = new List<Order>() { order1, order2, order3, order4, order5, order6, order7};

//Default Sort
orders.Sort();
foreach (Order order in orders)
{
    Console.WriteLine($"Default Sort: {order}");
}

//Sort by Classes
orders.Sort(new NameComparer());
foreach (Order order in orders)
{
    Console.WriteLine($"Name Sort: {order}");
}

orders.Sort(new PriceComparer());
foreach (Order order in orders)
{
    Console.WriteLine($"Price Sort: {order}");
}

orders.Sort(new AddressComparer());
foreach (Order order in orders)
{
    Console.WriteLine($"Address Sort: {order}");
}

//LINQ sorting
// Using LINQ to sort by name
var nameSortedOrders = orders.OrderBy(order => order.Name);
Console.WriteLine("\nName Sort using LINQ:");
foreach (Order order in nameSortedOrders)
{
    Console.WriteLine($"Name Sort: {order}");
}

// Using LINQ to sort by price
var priceSortedOrders = orders.OrderBy(order => order.Price);
Console.WriteLine("\nPrice Sort using LINQ:");
foreach (Order order in priceSortedOrders)
{
    Console.WriteLine($"Price Sort: {order}");
}

// Using LINQ to sort by address
var addressSortedOrders = orders.OrderBy(order => order.Address, StringComparer.OrdinalIgnoreCase);
Console.WriteLine("\nAddress Sort using LINQ:");
foreach (Order order in addressSortedOrders)
{
    Console.WriteLine($"Address Sort: {order}");
}

//LINQ where select orderby
var LinqSortedOrders = orders
    .Where(order => order.Price <= 100)
    .OrderBy(order => order.Name, StringComparer.OrdinalIgnoreCase)
    .Select(order => order.Name);
Console.WriteLine("\nGeneral Sort using LINQ:");
foreach (var order in LinqSortedOrders)
{
    Console.WriteLine($"General Sort: {order}");
}

//LINQ the most frequently used
var mostFrequentProductName = orders
    .GroupBy(order => order.Name, StringComparer.OrdinalIgnoreCase)
    .OrderByDescending(group => group.Count())
    .Select(group => group.Key)
    .FirstOrDefault();

if (mostFrequentProductName != null)
{
    Console.WriteLine($"Most Frequent Product Name: {mostFrequentProductName}");
}
else
{
    Console.WriteLine("No orders available.");
}

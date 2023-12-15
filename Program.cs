using OzTest1;

Order order1 = new Order("Whyskey", 3334445551112, 10, "Minsk");
Order order2 = new Order("Food", 3334447772212, 20, "Wro");
Order order3 = new Order("Sport", 3754448882212, 300, "Ber");
Order order4 = new VIPOrder("Martini", 3754448882212, 150, "Ber", "alko");
Order order5 = new DiscountOrder("Sprite", 3754448882212, 121, "Ber", 21);
Order order6 = new OrdinaryOrder("Fanta", 3334445551112, 33, "Minsk");


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
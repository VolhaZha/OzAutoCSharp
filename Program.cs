using OzTest1;

Order order1 = new Order("Whyskey", 3334445551112, 10, "Minsk");
Order order2 = new Order("Food", 3334447772212, 20, "Wro");
Order order3 = new Order("Sport", 3754448882212, 300, "Ber");

Order[] orderGeneral = { order1, order2, order3 };

foreach (Order order in orderGeneral)
{
    string phoneString = order.Phone.ToString();

    if (phoneString.StartsWith("375"))
    {
        Console.WriteLine($"Orders with phone starting from 375: {order}");
    }

    if (order.Price <= 20 & order.Name.StartsWith("Whys"))
    {
        Console.WriteLine($"Orders with Price not more then 20 and Name starting as Whys: {order}");
    }
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
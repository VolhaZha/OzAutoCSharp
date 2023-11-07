using OzTest1;

Order order1 = new Order("Whyskey", 333444555, 10, "Minsk");
Order order2 = new Order("Food", 333444777, 20, "Wro");
Order order3 = new Order("Sport", 375444888, 3000, "Ber");

Order[] orderGeneral = { order1, order2, order3 };

foreach (Order order in orderGeneral)
{
    string phoneString = order.Phone.ToString();
    
    if (phoneString.StartsWith("375"))
    {
        Console.WriteLine($"Orders with phone starting from 375: {order}");
    }
    
    if (order.Price <= 20 & order.Name.StartsWith ("Whys"))
    {
        Console.WriteLine($"Orders with Price not more then 20 and Name starting as Whys: {order}");
    }
}
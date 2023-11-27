
using OzTest1;

Order order1 = new Order("book", 333444555, 10, "Minsk");
Order order2 = new Order("food", 333444777, 20, "Wro");
Order order3 = new Order("sport", 333444888, 30, "Ber");

Order[] orderGeneral = { order1, order2, order3 };

foreach (Order order in orderGeneral)
{
    Console.WriteLine(order);
}
namespace OzProject
{
    public class DeliveryFoot: IDelivery
    {
        private const int DELIVERY_SPEED = 5; //km/h
        private readonly Random _random = new Random();

        public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Delivering order for {order.Name} to {order.Address}");
            Console.WriteLine("Order by foot delivery registered successfully!");
            Console.WriteLine();
        }

        public TimeSpan ExpectedDeliveryTime(Order order)
        {
            double distance = _random.Next(1, 30); // km
            double timeInHours = distance / DELIVERY_SPEED;

            return TimeSpan.FromHours(timeInHours);
        }
    }
}

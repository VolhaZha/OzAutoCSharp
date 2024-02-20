namespace OzProject
{
    public class DeliveryMoto: IDelivery
    {
        private const int DELIVERY_SPEED = 60; //km/h
        private readonly Random _random = new Random();

        public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Delivering order for {order.Name} to {order.Address}");
            Console.WriteLine("Order by moto delivery registered successfully!");
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

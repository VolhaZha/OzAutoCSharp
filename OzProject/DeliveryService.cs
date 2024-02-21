namespace OzProject
{
    public class DeliveryService
{
    private List<Order> _currentOrders = new List<Order>();
    private List<IDelivery> _deliveryProviders = new List<IDelivery>();

    public void AddOrder(Order order)
    {
        _currentOrders.Add(order);
    }

    public void AddDeliveryProvider(IDelivery deliveryProvider)
    {
        _deliveryProviders.Add(deliveryProvider);
    }

    public void ProcessOrders()
    {
            foreach (var order in _currentOrders)
            {
                IDelivery fastestProvider = FindFastestDeliveryProvider(order);

                Console.WriteLine($"Order: {order.Name}, Destination: {order.Address}");
                Console.WriteLine($"Fastest expected Delivery Time: {fastestProvider.ExpectedDeliveryTime(order)}");
                fastestProvider.DeliverOrder(order);
            }
        }

    public IDelivery FindFastestDeliveryProvider(Order order)
    {
        IDelivery fastestProvider = null;
        TimeSpan shortestTime = TimeSpan.MaxValue;

        foreach (var provider in _deliveryProviders)
        {
            TimeSpan deliveryTime = provider.ExpectedDeliveryTime(order);
            if (deliveryTime < shortestTime)
            {
                shortestTime = deliveryTime;
                fastestProvider = provider;
            }
        }

        return fastestProvider;
    }
}
}

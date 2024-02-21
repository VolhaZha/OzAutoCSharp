namespace OzProject
{
    public interface IDelivery
    {
        void DeliverOrder(Order order);
        TimeSpan ExpectedDeliveryTime(Order order);
    }
}

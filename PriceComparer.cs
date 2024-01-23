namespace OzTest1
{
    internal class PriceComparer : IComparer<Order>
    {
        public int Compare(Order? p1, Order? p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentException("Incorrect param value");
            return p1.Price.CompareTo(p2.Price);
        }
    }
}

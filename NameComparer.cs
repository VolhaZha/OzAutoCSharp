﻿namespace OzTest1
{
    internal class NameComparer : IComparer<Order>
    {
        public int Compare(Order? p1, Order? p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentException("Incorrect param value");
            return string.Compare(p1.Name, p2.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}

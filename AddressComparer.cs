﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzTest1
{
    internal class AddressComparer : IComparer<Order>
    {
        public int Compare(Order? p1, Order? p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentException("Некорректное значение параметра");
            return string.Compare(p1.Address, p2.Address, StringComparison.OrdinalIgnoreCase);
        }
    }
}

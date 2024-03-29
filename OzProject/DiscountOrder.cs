﻿namespace OzProject
{
    public class DiscountOrder : Order
    {
        public float Discount { get; set; }

        public DiscountOrder(string name, long phone, float price, string address, float discount) : base(name, phone, price, address)
        {
            Discount = discount;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Discount: {Discount}";
        }
    }
}

﻿namespace OzProject
{
    public class VIPOrder : Order
    {
        public string Description { get; set; }

        public VIPOrder(string name, long phone, float price, string address, string description) : base(name, phone, price, address)
        {
            Description = description;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Description: {Description}";
        }
    }
}

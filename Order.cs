using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzTest1
{
    internal class Order
    {
        private string name = "Name";
        private long phone;
        private float price;
        private string address = "Address";

        public string Name { get { return name; } set { name = value; } }
        public long Phone { get { return phone; } set { phone = value; } }
        public float Price { get { return price; } set { price = value; } }
        public string Address { get { return address; } set { address = value; } }

        public Order(string name, long phone, float price, string address)
        {
            Name = name;
            Phone = phone;
            Price = price;
            Address = address;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Order Number: {Phone}, Price: {Price}, Destination: {Address}";
        }
    }
}

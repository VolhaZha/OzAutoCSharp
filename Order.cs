namespace OzTest1
{
    internal class Order
    {
        private string _name = "Name";
        private long _phone;
        private float _price;
        private string _address = "Address";

        public string Name { get; set;}
        public long Phone { get; set; }
        public float Price { get; set; }
        public string Address { get; set; }

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

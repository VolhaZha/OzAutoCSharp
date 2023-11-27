namespace OzTest1
{
    internal class Order
    {
        private string _name;
        private long _phone;
        private float _price;
        private string _address;

        const long PHONE_LENGTH = 13;
        const float PRICE_LOW = 0;
        const float PRICE_HIGH = 1000;

        public string Name { get; set; }
        public long Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                string phoneString = value.ToString();
                if (phoneString.Length != PHONE_LENGTH)
                {
                    throw new Exception("Invalid Phone");
                }
            }
        }
        public float Price
        {
            get { return _price; }
            set
            {
                _price = value;
                if (value <= PRICE_LOW || value > PRICE_HIGH)
                {
                    throw new Exception("Invalid Price");
                }
            }
        }
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
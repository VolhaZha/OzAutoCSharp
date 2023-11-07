namespace OzTest1
{
    internal class Order
    {
        private string name;
        private long phone;
        private float price;
        private string address;

        public string Name { get { return name; } set { name = value; } }
        public long Phone { get { return phone; } set { phone = value;
                string phoneString = value.ToString();             
                if (phoneString.Length != 13)
                {
                  throw new Exception("Invalid Phone");
                }
            }
        }
        public float Price { get { return price; } set { price = value;
                if (value <= 0 || value > 1000)
                {
                    throw new Exception("Invalid Price");
                }
            }
        }
        public string Address { get { return address; } set { address = value; } }

        public Order(string name, long phone, float price, string address)
        {
            Name = name;
            try
            {
                Phone = phone;
            }           
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message} - for {name}");
            }
            try
            {
                Price = price;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message} - for {name}");
            }
            Address = address;
        }
        public override string ToString()
        {
            return $"Product: {Name}, Order Number: {Phone}, Price: {Price}, Destination: {Address}";
        }
    }
}

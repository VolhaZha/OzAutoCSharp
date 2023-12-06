namespace OzTest1
{
    internal class VIPOrder : Order
    {
        private string _description;
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

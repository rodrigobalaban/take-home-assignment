namespace Bank.Models
{
    public class Event
    {
        public string Type { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public float Amount { get; set; }
    }
}

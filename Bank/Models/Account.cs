namespace Bank.Models
{
    public class Account
    {
        public string Id { get; set; }
        public float Balance { get; set; }

        public Account(string id, float balance)
        {
            Id = id;
            Balance = balance;
        }
    }
}

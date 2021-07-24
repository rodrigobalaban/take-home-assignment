namespace Bank.Models
{
    public class DestinationAccount
    {
        public Account Destination { get; set; }

        public DestinationAccount(Account destination)
        {
            Destination = destination;
        }
    }
}

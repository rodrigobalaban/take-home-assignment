namespace Bank.Models
{
    public class EventResponse
    {
        public Account Destination { get; set; }
        public Account Origin { get; set; }        

        public EventResponse(Account destination, Account origin)
        {
            Destination = destination;
            Origin = origin;
        }
    }
}

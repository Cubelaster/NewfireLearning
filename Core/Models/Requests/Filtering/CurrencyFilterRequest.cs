namespace Core.Models.Requests.Filtering
{
    public class CurrencyFilterRequest : CodebooksBaseFilterRequest
    {
        public string Number { get; set; }
        public string Symbol { get; set; }
    }
}

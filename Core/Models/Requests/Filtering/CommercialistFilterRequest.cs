namespace Core.Models.Requests.Filtering
{
    public class CommercialistFilterRequest : CodebooksBaseFilterRequest
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
    }
}

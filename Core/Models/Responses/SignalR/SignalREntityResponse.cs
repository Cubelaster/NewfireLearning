using Core.Enums;

namespace Core.Models.Responses.SignalR
{
    public class SignalREntityResponse<U> where U : struct
    {
        public U Id { get; set; }
        public EntityType EntityType { get; set; }
    }
}

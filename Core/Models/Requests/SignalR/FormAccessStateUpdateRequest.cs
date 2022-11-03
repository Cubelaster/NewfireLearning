namespace Core.Models.Requests.SignalR
{
    public class FormAccessStateUpdateRequest
    {
        /// <summary>
        /// Not always string, actually never string. Either int or Guid
        /// Also, if not supplied, it basically means it's Create mode
        /// </summary>
        public string EntityId { get; set; }
        public int EntityType { get; set; }
        public object AdditionalData { get; set; }
    }
}

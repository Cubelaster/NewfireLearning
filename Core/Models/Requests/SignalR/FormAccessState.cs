using Core.Enums;

namespace Core.Models.Requests.SignalR
{
    /// <summary>
    /// State defining FormAccess
    /// EntityId can be null, meaning it's Create mode
    /// For some fing reason or the other, SignalR Client won't send the request 
    /// if the object doesn't 100% match what's in the signature object
    /// Meaning if request has EntityId and EntityType but is missing UserId
    /// It will just straight out refuse to connect
    /// smh
    /// </summary>
    public class FormAccessState
    {
        public string ConnectionId { get; set; }
        public string EntityId { get; set; }
        public EntityType EntityType { get; set; }
        /// <summary>
        /// Record type meant to serve as a PK for any form
        /// Basically compare every property to determine equality
        /// </summary>
        public object AdditionalData { get; set; }
        /// <summary>
        /// Not reliably used because the connection loses token on reconnect. 
        /// There are some issues open and some people having the same issue but no easy fix
        /// Would be great if we had authorization for SignalR but it's not functional at the moment
        /// </summary>
        public string UserId { get; set; }
        public int Instances { get; set; }
    }
}

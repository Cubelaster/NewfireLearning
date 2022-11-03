using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class DocumentChangeStatusRequest : BaseRequest
    {
        public Guid Id { get; set; }
        public int StatusId { get; set; }
    }
}

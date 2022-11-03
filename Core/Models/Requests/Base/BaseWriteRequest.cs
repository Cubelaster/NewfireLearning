namespace Core.Models.Requests.Base
{
    public class BaseWriteRequest<U> : BaseRequest, IBaseUpdateRequest<U> where U : struct
    {
        public U? Id { get; set; }
    }
}

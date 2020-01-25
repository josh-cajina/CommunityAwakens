using System;

namespace CommunityAwakens.Api.Responses
{
    public class BaseResponse<T>
    {
        public T Data { get; set; }
        public DateTime GeneratedAt => DateTime.Now;

        public BaseResponse(T data)
        {
            Data = data;
        }
    }
}

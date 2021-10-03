using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class ApiSuccessResponse<T> : ApiResponse
    {
        public ApiSuccessResponse(T value)
        {
            Data = value;
        }

        public T Data { get; set; }
    }

    public class ApiResponse
    {
        public Status Status { get; set; }
    }

    public enum Status
    {
        Success,

        Failure
    }
}

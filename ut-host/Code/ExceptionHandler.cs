using Contracts.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ut_host.Code
{
    public class ExceptionHandler : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                Error errResponse = new Error() { Message = ex.Message };
                var jsonSerializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    Converters = { new Newtonsoft.Json.Converters.StringEnumConverter() }
                };
                var res = JsonConvert.SerializeObject(new ApiSuccessResponse<Error>(errResponse) { Status = Status.Failure }, jsonSerializerSettings);
                context.Response.ContentType = "application/json";
                await context.Response.Body.WriteAsync(Encoding.UTF8.GetBytes(res));
            }
        }
    }
}

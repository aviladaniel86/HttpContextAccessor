using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpContextAccessor.Services
{
    public class RequestService : IRequestService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RequestService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// This method is used to get access to the HttpContext from service class
        /// </summary>
        /// <returns></returns>
        public string GetRequestPath()
        {
            return $"User requested {_httpContextAccessor.HttpContext.Request.Method} from {_httpContextAccessor.HttpContext.Request.Path.Value} path" ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpContextAccessor.Services
{
    public interface IRequestService
    {
        string GetRequestPath();
    }
}

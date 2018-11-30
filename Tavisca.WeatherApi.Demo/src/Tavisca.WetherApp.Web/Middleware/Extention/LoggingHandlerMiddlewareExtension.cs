using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tavisca.WetherApp.Web.Middleware.Extention
{
    public static class LoggingHandlerMiddlewareExtension
    {
        public static IApplicationBuilder UseLogginerHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingHandlerMiddleware>();
        }
    }
}
